using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WristStrapControlApp.DAL.Entities;

namespace WristStrapControlApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<WristStrapLog> WristStrapLogs { get; set; }

        public DbSet<AlarmLog> AlarmLogs { get; set; }
        public DbSet<CurrentStationStatus> currentStationStatuses { get; set; }
        public DbSet<MonitorDevice> monitorDevices { get; set; }
        public DbSet<Operator> operators { get; set; }
        public DbSet<ProductionLine> productionLines { get; set; }
        public DbSet<Station> stations { get; set; }
        public static async Task InitializeDatabaseAsync()
        {
            using (var context = new AppDbContext())
            {
                // EnsureCreatedAsync sẽ:
                // 1. Kiểm tra xem Database có tồn tại chưa.
                // 2. Nếu chưa có: Tự động CREATE DATABASE và CREATE tất cả các BẢNG theo Model C# mà không cần file Migration.
                // 3. Nếu có rồi: Bỏ qua và giữ nguyên dữ liệu hiện tại.
                await context.Database.EnsureCreatedAsync();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Đảm bảo luôn cấu hình UseSqlServer nếu chưa được cấu hình từ bên ngoài
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = IniConfigManager.GetConnectionString();
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình entity không có Key
            modelBuilder.Entity<CurrentStationStatus>().HasNoKey();

            // Bỏ qua thuộc tính CurrentStatus trong Station
            modelBuilder.Entity<Station>().Ignore(s => s.CurrentStatus);

            // Tắt Cascade Delete cho tất cả quan hệ Khóa ngoại
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
