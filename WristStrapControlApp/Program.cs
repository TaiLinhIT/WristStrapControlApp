using WristStrapControlApp.DAL;

namespace WristStrapControlApp
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Tự động tạo CSDL & Bảng nếu chưa tồn tại
                await AppDbContext.InitializeDatabaseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo CSDL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new Form1());
        }
    }
}