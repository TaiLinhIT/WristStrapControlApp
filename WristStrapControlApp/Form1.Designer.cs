namespace WristStrapControlApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            lblDateTime = new Label();
            picAlarm = new PictureBox();
            tabControlMain = new TabControl();
            tabHome = new TabPage();
            dgvHistory = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colProcess = new DataGridViewTextBoxColumn();
            colOperator = new DataGridViewTextBoxColumn();
            colOldStatus = new DataGridViewTextBoxColumn();
            colNewStatus = new DataGridViewTextBoxColumn();
            colResult = new DataGridViewTextBoxColumn();
            pnlBottomHome = new Panel();
            lblTotalRecords = new Label();
            pnlPaging = new Panel();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            btnExportExcel = new Button();
            btnPrint = new Button();
            pnlFilter = new Panel();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblProcess = new Label();
            cboProcess = new ComboBox();
            lblOperator = new Label();
            txtOperator = new TextBox();
            lblResult = new Label();
            cboResult = new ComboBox();
            btnSearch = new Button();
            tabSetting = new TabPage();
            grpDbConfig = new GroupBox();
            lblIp = new Label();
            txtIp = new TextBox();
            txtDatabase = new TextBox();
            lblDatabase = new Label();
            lblTable = new Label();
            txtTable = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnTestConnection = new Button();
            btnSaveConfig = new Button();
            pnlAuth = new Panel();
            lblAuthTitle = new Label();
            txtAuthPassword = new TextBox();
            btnUnlock = new Button();
            lblFooter = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlarm).BeginInit();
            tabControlMain.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlBottomHome.SuspendLayout();
            pnlPaging.SuspendLayout();
            pnlFilter.SuspendLayout();
            tabSetting.SuspendLayout();
            grpDbConfig.SuspendLayout();
            pnlAuth.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 51, 102);
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(lblDateTime);
            pnlHeader.Controls.Add(picAlarm);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1417, 87);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeaderSubtitle.ForeColor = Color.White;
            lblHeaderSubtitle.Location = new Point(17, 16);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(110, 40);
            lblHeaderSubtitle.TabIndex = 0;
            lblHeaderSubtitle.Text = "FACTORY\nESD CONTROL";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Anchor = AnchorStyles.Top;
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(434, 16);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(513, 46);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "WRIST STRAP USAGE HISTORY";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(1166, 16);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(183, 53);
            lblDateTime.TabIndex = 2;
            lblDateTime.Text = "2026-09-12 (Sat)\n08:49:30";
            lblDateTime.TextAlign = ContentAlignment.TopRight;
            // 
            // picAlarm
            // 
            picAlarm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picAlarm.BackColor = Color.Red;
            picAlarm.Location = new Point(1360, 20);
            picAlarm.Margin = new Padding(3, 4, 3, 4);
            picAlarm.Name = "picAlarm";
            picAlarm.Size = new Size(40, 47);
            picAlarm.TabIndex = 3;
            picAlarm.TabStop = false;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabHome);
            tabControlMain.Controls.Add(tabSetting);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControlMain.ItemSize = new Size(120, 35);
            tabControlMain.Location = new Point(0, 87);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1417, 807);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 1;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.FromArgb(240, 243, 246);
            tabHome.Controls.Add(dgvHistory);
            tabHome.Controls.Add(pnlBottomHome);
            tabHome.Controls.Add(pnlFilter);
            tabHome.Location = new Point(4, 39);
            tabHome.Margin = new Padding(3, 4, 3, 4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3, 4, 3, 4);
            tabHome.Size = new Size(1409, 764);
            tabHome.TabIndex = 0;
            tabHome.Text = "🏠  Home";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 102, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeight = 35;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colTime, colProcess, colOperator, colOldStatus, colNewStatus, colResult });
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.Location = new Point(3, 77);
            dgvHistory.Margin = new Padding(3, 4, 3, 4);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 30;
            dgvHistory.Size = new Size(1403, 607);
            dgvHistory.TabIndex = 0;
            dgvHistory.CellFormatting += dgvHistory_CellFormatting;
            // 
            // colNo
            // 
            colNo.FillWeight = 40F;
            colNo.HeaderText = "No.";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 80F;
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.FillWeight = 80F;
            colTime.HeaderText = "Time";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colProcess
            // 
            colProcess.HeaderText = "Process / Station";
            colProcess.MinimumWidth = 6;
            colProcess.Name = "colProcess";
            colProcess.ReadOnly = true;
            // 
            // colOperator
            // 
            colOperator.FillWeight = 120F;
            colOperator.HeaderText = "Operator";
            colOperator.MinimumWidth = 6;
            colOperator.Name = "colOperator";
            colOperator.ReadOnly = true;
            // 
            // colOldStatus
            // 
            colOldStatus.FillWeight = 90F;
            colOldStatus.HeaderText = "Old Status";
            colOldStatus.MinimumWidth = 6;
            colOldStatus.Name = "colOldStatus";
            colOldStatus.ReadOnly = true;
            // 
            // colNewStatus
            // 
            colNewStatus.FillWeight = 90F;
            colNewStatus.HeaderText = "New Status";
            colNewStatus.MinimumWidth = 6;
            colNewStatus.Name = "colNewStatus";
            colNewStatus.ReadOnly = true;
            // 
            // colResult
            // 
            colResult.FillWeight = 90F;
            colResult.HeaderText = "Result";
            colResult.MinimumWidth = 6;
            colResult.Name = "colResult";
            colResult.ReadOnly = true;
            // 
            // pnlBottomHome
            // 
            pnlBottomHome.BackColor = Color.FromArgb(0, 51, 102);
            pnlBottomHome.Controls.Add(lblTotalRecords);
            pnlBottomHome.Controls.Add(pnlPaging);
            pnlBottomHome.Controls.Add(btnExportExcel);
            pnlBottomHome.Controls.Add(btnPrint);
            pnlBottomHome.Dock = DockStyle.Bottom;
            pnlBottomHome.Location = new Point(3, 684);
            pnlBottomHome.Margin = new Padding(3, 4, 3, 4);
            pnlBottomHome.Name = "pnlBottomHome";
            pnlBottomHome.Size = new Size(1403, 76);
            pnlBottomHome.TabIndex = 1;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.ForeColor = Color.White;
            lblTotalRecords.Location = new Point(17, 24);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(177, 23);
            lblTotalRecords.TabIndex = 0;
            lblTotalRecords.Text = "Total Records : 1,250";
            // 
            // pnlPaging
            // 
            pnlPaging.Anchor = AnchorStyles.Top;
            pnlPaging.Controls.Add(btnFirst);
            pnlPaging.Controls.Add(btnPrev);
            pnlPaging.Controls.Add(lblPageInfo);
            pnlPaging.Controls.Add(btnNext);
            pnlPaging.Controls.Add(btnLast);
            pnlPaging.Location = new Point(458, 13);
            pnlPaging.Margin = new Padding(3, 4, 3, 4);
            pnlPaging.Name = "pnlPaging";
            pnlPaging.Size = new Size(297, 47);
            pnlPaging.TabIndex = 1;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(0, 3);
            btnFirst.Margin = new Padding(3, 4, 3, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(40, 40);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "|<";
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(46, 3);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 40);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "<";
            // 
            // lblPageInfo
            // 
            lblPageInfo.ForeColor = Color.White;
            lblPageInfo.Location = new Point(91, 3);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(114, 40);
            lblPageInfo.TabIndex = 2;
            lblPageInfo.Text = "1 / 125";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(211, 3);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 40);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            // 
            // btnLast
            // 
            btnLast.Location = new Point(257, 3);
            btnLast.Margin = new Padding(3, 4, 3, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(40, 40);
            btnLast.TabIndex = 4;
            btnLast.Text = ">|";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportExcel.BackColor = Color.FromArgb(0, 102, 204);
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(1111, 13);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(137, 47);
            btnExportExcel.TabIndex = 2;
            btnExportExcel.Text = "📊 Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(0, 102, 204);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1259, 13);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(126, 47);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "🖨 Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(0, 80, 158);
            pnlFilter.Controls.Add(lblFromDate);
            pnlFilter.Controls.Add(dtpFromDate);
            pnlFilter.Controls.Add(lblToDate);
            pnlFilter.Controls.Add(dtpToDate);
            pnlFilter.Controls.Add(lblProcess);
            pnlFilter.Controls.Add(cboProcess);
            pnlFilter.Controls.Add(lblOperator);
            pnlFilter.Controls.Add(txtOperator);
            pnlFilter.Controls.Add(lblResult);
            pnlFilter.Controls.Add(cboResult);
            pnlFilter.Controls.Add(btnSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(3, 4);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1403, 73);
            pnlFilter.TabIndex = 2;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.ForeColor = Color.White;
            lblFromDate.Location = new Point(11, 8);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(95, 23);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(11, 32);
            dtpFromDate.Margin = new Padding(3, 4, 3, 4);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(137, 30);
            dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.ForeColor = Color.White;
            lblToDate.Location = new Point(166, 8);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(71, 23);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "To Date";
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(166, 32);
            dtpToDate.Margin = new Padding(3, 4, 3, 4);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(137, 30);
            dtpToDate.TabIndex = 3;
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            lblProcess.ForeColor = Color.White;
            lblProcess.Location = new Point(320, 8);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(144, 23);
            lblProcess.TabIndex = 4;
            lblProcess.Text = "Process / Station";
            // 
            // cboProcess
            // 
            cboProcess.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProcess.Items.AddRange(new object[] { "All", "S3.1", "S8.2", "S9.1", "S2.2", "S8.5", "Bending", "S5.2", "S3.3" });
            cboProcess.Location = new Point(320, 32);
            cboProcess.Margin = new Padding(3, 4, 3, 4);
            cboProcess.Name = "cboProcess";
            cboProcess.Size = new Size(171, 31);
            cboProcess.TabIndex = 5;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.ForeColor = Color.White;
            lblOperator.Location = new Point(509, 8);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(83, 23);
            lblOperator.TabIndex = 6;
            lblOperator.Text = "Operator";
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(509, 32);
            txtOperator.Margin = new Padding(3, 4, 3, 4);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(205, 30);
            txtOperator.TabIndex = 7;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(731, 8);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 23);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // cboResult
            // 
            cboResult.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResult.Items.AddRange(new object[] { "All", "OK", "NG" });
            cboResult.Location = new Point(731, 32);
            cboResult.Margin = new Padding(3, 4, 3, 4);
            cboResult.Name = "cboResult";
            cboResult.Size = new Size(125, 31);
            cboResult.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 122, 204);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(880, 21);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 44);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tabSetting
            // 
            tabSetting.BackColor = Color.FromArgb(245, 247, 250);
            tabSetting.Controls.Add(grpDbConfig);
            tabSetting.Controls.Add(pnlAuth);
            tabSetting.Location = new Point(4, 39);
            tabSetting.Margin = new Padding(3, 4, 3, 4);
            tabSetting.Name = "tabSetting";
            tabSetting.Padding = new Padding(23, 27, 23, 27);
            tabSetting.Size = new Size(1409, 764);
            tabSetting.TabIndex = 1;
            tabSetting.Text = "⚙️  Setting";
            // 
            // grpDbConfig
            // 
            grpDbConfig.BackColor = Color.White;
            grpDbConfig.Controls.Add(lblIp);
            grpDbConfig.Controls.Add(txtIp);
            grpDbConfig.Controls.Add(txtDatabase);
            grpDbConfig.Controls.Add(lblDatabase);
            grpDbConfig.Controls.Add(lblTable);
            grpDbConfig.Controls.Add(txtTable);
            grpDbConfig.Controls.Add(lblUsername);
            grpDbConfig.Controls.Add(txtUsername);
            grpDbConfig.Controls.Add(lblPassword);
            grpDbConfig.Controls.Add(txtPassword);
            grpDbConfig.Controls.Add(btnTestConnection);
            grpDbConfig.Controls.Add(btnSaveConfig);
            grpDbConfig.Enabled = false;
            grpDbConfig.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDbConfig.ForeColor = Color.FromArgb(0, 51, 102);
            grpDbConfig.Location = new Point(29, 27);
            grpDbConfig.Margin = new Padding(3, 4, 3, 4);
            grpDbConfig.Name = "grpDbConfig";
            grpDbConfig.Padding = new Padding(3, 4, 3, 4);
            grpDbConfig.Size = new Size(743, 560);
            grpDbConfig.TabIndex = 0;
            grpDbConfig.TabStop = false;
            grpDbConfig.Text = "Database Configuration";
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Location = new Point(37, 60);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(111, 25);
            lblIp.TabIndex = 0;
            lblIp.Text = "IP Address:";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(194, 60);
            txtIp.Margin = new Padding(3, 4, 3, 4);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(479, 32);
            txtIp.TabIndex = 1;
            txtIp.Text = "10.137.104.8";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(194, 118);
            txtDatabase.Margin = new Padding(3, 4, 3, 4);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(479, 32);
            txtDatabase.TabIndex = 3;
            txtDatabase.Text = "proj";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(37, 118);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(98, 25);
            lblDatabase.TabIndex = 2;
            lblDatabase.Text = "Database:";
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Location = new Point(46, 314);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(63, 25);
            lblTable.TabIndex = 4;
            lblTable.Text = "Table:";
            // 
            // txtTable
            // 
            txtTable.Location = new Point(194, 314);
            txtTable.Margin = new Padding(3, 4, 3, 4);
            txtTable.Name = "txtTable";
            txtTable.Size = new Size(479, 32);
            txtTable.TabIndex = 5;
            txtTable.Text = "navian_tide_touch_compa";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(34, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 25);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "User Name:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(194, 172);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(479, 32);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "root";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(37, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 25);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 229);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(479, 32);
            txtPassword.TabIndex = 11;
            txtPassword.Text = "123456";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.FromArgb(108, 117, 125);
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(206, 467);
            btnTestConnection.Margin = new Padding(3, 4, 3, 4);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(206, 53);
            btnTestConnection.TabIndex = 12;
            btnTestConnection.Text = "⚡ Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.BackColor = Color.FromArgb(40, 167, 69);
            btnSaveConfig.FlatStyle = FlatStyle.Flat;
            btnSaveConfig.ForeColor = Color.White;
            btnSaveConfig.Location = new Point(434, 467);
            btnSaveConfig.Margin = new Padding(3, 4, 3, 4);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(251, 53);
            btnSaveConfig.TabIndex = 13;
            btnSaveConfig.Text = "💾 Save Configuration";
            btnSaveConfig.UseVisualStyleBackColor = false;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // pnlAuth
            // 
            pnlAuth.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlAuth.BackColor = Color.White;
            pnlAuth.BorderStyle = BorderStyle.FixedSingle;
            pnlAuth.Controls.Add(lblAuthTitle);
            pnlAuth.Controls.Add(txtAuthPassword);
            pnlAuth.Controls.Add(btnUnlock);
            pnlAuth.Location = new Point(857, 480);
            pnlAuth.Margin = new Padding(3, 4, 3, 4);
            pnlAuth.Name = "pnlAuth";
            pnlAuth.Size = new Size(514, 106);
            pnlAuth.TabIndex = 1;
            // 
            // lblAuthTitle
            // 
            lblAuthTitle.AutoSize = true;
            lblAuthTitle.Location = new Point(17, 37);
            lblAuthTitle.Name = "lblAuthTitle";
            lblAuthTitle.Size = new Size(149, 23);
            lblAuthTitle.TabIndex = 0;
            lblAuthTitle.Text = "Admin Password:";
            // 
            // txtAuthPassword
            // 
            txtAuthPassword.Location = new Point(171, 33);
            txtAuthPassword.Margin = new Padding(3, 4, 3, 4);
            txtAuthPassword.Name = "txtAuthPassword";
            txtAuthPassword.Size = new Size(205, 30);
            txtAuthPassword.TabIndex = 1;
            txtAuthPassword.UseSystemPasswordChar = true;
            // 
            // btnUnlock
            // 
            btnUnlock.BackColor = Color.FromArgb(0, 102, 204);
            btnUnlock.FlatStyle = FlatStyle.Flat;
            btnUnlock.ForeColor = Color.White;
            btnUnlock.Location = new Point(389, 31);
            btnUnlock.Margin = new Padding(3, 4, 3, 4);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(103, 40);
            btnUnlock.TabIndex = 2;
            btnUnlock.Text = "Open!";
            btnUnlock.UseVisualStyleBackColor = false;
            btnUnlock.Click += btnUnlock_Click;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.FromArgb(0, 51, 102);
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFooter.ForeColor = Color.White;
            lblFooter.Location = new Point(0, 894);
            lblFooter.Name = "lblFooter";
            lblFooter.Padding = new Padding(11, 4, 0, 0);
            lblFooter.Size = new Size(1417, 33);
            lblFooter.TabIndex = 2;
            lblFooter.Text = "SAFETY FIRST – ESD CONTROL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 927);
            Controls.Add(tabControlMain);
            Controls.Add(pnlHeader);
            Controls.Add(lblFooter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESD Control System";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlarm).EndInit();
            tabControlMain.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlBottomHome.ResumeLayout(false);
            pnlBottomHome.PerformLayout();
            pnlPaging.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            tabSetting.ResumeLayout(false);
            grpDbConfig.ResumeLayout(false);
            grpDbConfig.PerformLayout();
            pnlAuth.ResumeLayout(false);
            pnlAuth.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PictureBox picAlarm;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSetting;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cboResult;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;

        private System.Windows.Forms.Panel pnlBottomHome;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Panel pnlPaging;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;

        private System.Windows.Forms.GroupBox grpDbConfig;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnTestConnection;

        private System.Windows.Forms.Panel pnlAuth;
        private System.Windows.Forms.Label lblAuthTitle;
        private System.Windows.Forms.TextBox txtAuthPassword;
        private System.Windows.Forms.Button btnUnlock;

        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Timer timerClock;
    }
}