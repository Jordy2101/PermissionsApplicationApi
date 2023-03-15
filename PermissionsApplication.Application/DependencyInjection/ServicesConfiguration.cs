using Microsoft.Extensions.DependencyInjection;
using PermissionsApplication.Application.Features.Permission.CreatePermissions;
using PermissionsApplication.Application.Features.Permission.DeletePermissions;
using PermissionsApplication.Application.Features.Permission.GetOnePermissions;
using PermissionsApplication.Application.Features.Permission.PagedPermissions;
using PermissionsApplication.Application.Features.Permission.UpdatePermissions;
using PermissionsApplication.Application.Features.TypePermission.GetListTypePermissions;
using System.Reflection;

namespace PermissionsApplication.Application.DependencyInjection
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICreatePermissionsCommand, CreatePermissionsCommand>();
            services.AddScoped<IDeletePermissionsCommand, DeletePermissionsCommand>();
            services.AddScoped<IGetOnePermissionsQueries, GetOnePermissionsQueries>();
            services.AddScoped<IPagedPermissionsQueries, PagedPermissionsQueries>();
            services.AddScoped<IUpdatePermissionsCommand, UpdatePermissionsCommand>();
            services.AddScoped<IGetListTypePermissionsQueries, GetListTypePermissionsQueries>();
        }
    }
}
