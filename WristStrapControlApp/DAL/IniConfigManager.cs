using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL
{
    public class DbConfigModel
    {
        public string Server { get; set; } = @".\SQLEXPRESS";
        public string Database { get; set; } = "proj";
        public string Table { get; set; } = "navian_tide_touch_compa";
        public string PrevTable { get; set; } = "tidetouch_navian_fa_func";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public static class IniConfigManager
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

        // 1. Hàm đọc File INI
        public static DbConfigModel ReadConfig()
        {
            var config = new DbConfigModel();
            try
            {
                if (!File.Exists(FilePath))
                {
                    SaveConfig(config);
                    return config;
                }

                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(FilePath);

                config.Server = data["Config"]["IP"] ?? config.Server;
                config.Database = data["Config"]["Database"] ?? config.Database;
                config.Table = data["Config"]["Table"] ?? config.Table;
                config.PrevTable = data["Config"]["PreviousTable"] ?? config.PrevTable;
                config.Username = data["Config"]["Username"] ?? config.Username;
                config.Password = data["Config"]["Password"] ?? config.Password;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đọc file INI: " + ex.Message);
            }
            return config;
        }

        // 2. Hàm lưu File INI
        public static void SaveConfig(DbConfigModel config)
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = new IniData();

                data["Config"]["IP"] = config.Server;
                data["Config"]["Database"] = config.Database;
                data["Config"]["Table"] = config.Table;
                data["Config"]["PreviousTable"] = config.PrevTable;
                data["Config"]["Username"] = config.Username;
                data["Config"]["Password"] = config.Password;

                parser.WriteFile(FilePath, data);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể lưu file config.ini: " + ex.Message);
            }
        }

        // 3. Hàm tạo Connection String (Sửa lỗi thiếu định nghĩa GetConnectionString)
        public static string GetConnectionString()
        {
            var config = ReadConfig(); // Gọi trực tiếp ReadConfig trong cùng class

            if (string.IsNullOrWhiteSpace(config.Username))
            {
                // Dùng Windows Authentication
                return $"Server={config.Server};Database={config.Database};Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
            }
            else
            {
                // Dùng SQL Server Authentication
                return $"Server={config.Server};Database={config.Database};User Id={config.Username};Password={config.Password};TrustServerCertificate=True;Encrypt=False;";
            }
        }
    }
}
