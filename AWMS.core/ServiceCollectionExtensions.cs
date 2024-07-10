using AWMS.datalayer;
using AWMS.datalayer.Context;
using AWMS.datalayer.Repositories;
using AWMS.core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AWMS.core
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLibraryServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AWMScontext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IMrService, MrService>();
            services.AddScoped<IPoService, PoService>();

            return services;
        }
    }
}
