using AWMS.dapper.DapperContext;
using AWMS.dapper.Repositories;
using LibraryApp.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AWMS.dapper
{
    public static class DapperServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperLibraryServices(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<DapperContext.DapperContext>(); // اضافه کردن DapperContext به DI
            services.AddScoped<IPackingListDapperRepository, PackingListDapperRepository>();

            return services;
        }
    }
}
