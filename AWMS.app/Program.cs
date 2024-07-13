using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;
using AWMS.core;
using AWMS.datalayer;
using AWMS.datalayer.Context;
using AWMS.datalayer.Repositories;
using AWMS.core.Interfaces;
using AWMS.app.Forms;
using AWMS.app.Forms.RibbonMaterial;
using Microsoft.EntityFrameworkCore;
using AWMS.dapper.Repositories;
using AWMS.dapper;
using AWMS.app.Forms.frmSmall;

namespace AWMS.app
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ساخت Host برای استفاده از DI
            var host = CreateHostBuilder().Build();

            // ایجاد Scope برای دریافت سرویس‌ها
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    // دریافت فرم اصلی از سرویس‌ها
                    var form = services.GetRequiredService<frmMain>();
                    Application.Run(form);
                }
                catch (Exception ex)
                {
                    // هندل کردن خطاها
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        // تنظیمات اولیه Host
        private static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // بارگذاری تنظیمات از فایل appsettings.json
                    IConfiguration configuration = LoadConfiguration();
                    string connectionString = configuration.GetConnectionString("DefaultConnection")!;

                    // افزودن DbContext و UnitOfWork به سرویس‌ها
                    services.AddDbContext<AWMScontext>(options =>
                        options.UseSqlServer(connectionString));
                    services.AddScoped<IUnitOfWork, UnitOfWork>();

                    //EF Repositories
                    services.AddScoped<IMrService, MrService>();
                    services.AddScoped<IPoService, PoService>();
                    services.AddScoped<IDescriptionForPkService, DescriptionForPkService>();

                    //Dapper Repositories
                    services.AddScoped<IPackingListDapperRepository, PackingListDapperRepository>();

                    // افزودن سرویس‌های فرم‌ها به سرویس‌ها
                    services.AddTransient<frmMain>();
                    services.AddTransient<frmCompanyManagment>();
                    services.AddTransient<frmMr>();
                    services.AddTransient<frmPo>();
                    services.AddTransient<frmPl>();
                    services.AddTransient<frmDescriptionForPKPL>();
                });

        // بارگذاری تنظیمات از فایل appsettings.json
        private static IConfiguration LoadConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}
