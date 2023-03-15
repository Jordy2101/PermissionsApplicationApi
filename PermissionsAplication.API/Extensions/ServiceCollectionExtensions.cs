using Microsoft.EntityFrameworkCore;
using PermissionsApplication.DataAccess.Context;

namespace PermissionsAplication.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddContextInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PermissionsApplicationContext>(options => options.UseSqlServer(configuration.GetValue<string>("ConnectionStrings:PermissionsConnection")));
        }
    }
}
