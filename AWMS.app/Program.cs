using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;
using AWMS.core;

namespace AWMS.app
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form = services.GetRequiredService<Forms.frmMain>();
                    Application.Run(form);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    IConfiguration configuration = LoadConfiguration();
                    string connectionString = configuration.GetConnectionString("DefaultConnection");
                    services.AddLibraryServices(connectionString);

                    services.AddTransient<Forms.frmMain>();
                    services.AddTransient<Forms.frmCompanyManagment>();
                    services.AddTransient<Forms.RibbonMaterial.frmMr>();
                    services.AddTransient<Forms.RibbonMaterial.frmPo>();
                    services.AddTransient<Forms.RibbonMaterial.frmPl>();
                    
                   });

        private static IConfiguration LoadConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}