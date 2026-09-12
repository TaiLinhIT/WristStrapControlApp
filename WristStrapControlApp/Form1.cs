using WristStrapControlApp.DAL;

namespace WristStrapControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            // Clock event
            timerClock.Interval = 1000;
            timerClock.Tick += (s, e) =>
            {
                lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd (ddd)\nHH:mm:ss");
            };
            timerClock.Start();

            // Form Load & Unlock
            this.Load += Form1_Load;
            btnUnlock.Click += btnUnlock_Click;

            // Save & Test Connection
            btnSaveConfig.Click += btnSaveConfig_Click;
            btnTestConnection.Click += btnTestConnection_Click;
            btnSearch.Click += async (s, e) => await LoadDataFromDbAsync();

            // Format DataGridView Status Cells
            dgvHistory.CellFormatting += dgvHistory_CellFormatting;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            LoadConfigToUI();
            await LoadDataFromDbAsync();
        }
        // Đọc cấu hình từ file INI hiển thị lên UI Setting
        private void LoadConfigToUI()
        {
            var config = IniConfigManager.ReadConfig();
            txtIp.Text = config.Server;
            txtDatabase.Text = config.Database;
            txtTable.Text = config.Table;
            txtUsername.Text = config.Username;
            txtPassword.Text = config.Password;
        }

        private async void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                var config = new DbConfigModel
                {
                    Server = txtIp.Text.Trim(),
                    Database = txtDatabase.Text.Trim(),
                    Table = txtTable.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                IniConfigManager.SaveConfig(config);
                MessageBox.Show("Đã lưu cấu hình vào config.ini thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload lại dữ liệu ở Home sau khi lưu kết nối mới
                await LoadDataFromDbAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu cấu hình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    if (context.Database.CanConnect())
                    {
                        MessageBox.Show("Kết nối tới Database thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối tới Database. Vui lòng kiểm tra lại thông số!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Tải dữ liệu bằng EF Core Async từ CSDL
        private async Task LoadDataFromDbAsync()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    if (!await context.Database.CanConnectAsync())
                        return;

                    var query = context.WristStrapLogs.AsQueryable();

                    // Lọc theo operator nếu có nhập
                    if (!string.IsNullOrEmpty(txtOperator.Text))
                    {
                        query = query.Where(x => x.Operator.Contains(txtOperator.Text.Trim()));
                    }

                    var list = query.OrderByDescending(x => x.Date)
                                    .ThenByDescending(x => x.Time)
                                    .Take(100)
                                    .ToList();

                    dgvHistory.DataSource = list;
                    lblTotalRecords.Text = $"Total Records : {list.Count}";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu bảng chưa tồn tại hoặc sai thông tin đăng nhập
                Console.WriteLine("Lỗi đọc CSDL: " + ex.Message);
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtAuthPassword.Text == "admin" || txtAuthPassword.Text == "123456")
            {
                grpDbConfig.Enabled = true;
                MessageBox.Show("Đã mở khóa cấu hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAuthPassword.Clear();
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;
            string strVal = e.Value.ToString();

            if (strVal == "OK")
            {
                e.CellStyle.BackColor = Color.FromArgb(40, 167, 69);
                e.CellStyle.ForeColor = Color.White;
            }
            else if (strVal == "NG")
            {
                e.CellStyle.BackColor = Color.FromArgb(220, 53, 69);
                e.CellStyle.ForeColor = Color.White;
            }
            else if (strVal == "Not Connected")
            {
                e.CellStyle.BackColor = Color.Gray;
                e.CellStyle.ForeColor = Color.White;
            }
        }
    }
}
