using Microsoft.Extensions.DependencyInjection;
using PermissionsApplication.DataAccess.Repositories;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.DataAccess.DependecyInjection
{
    public static class RepositoriesCollectionConfiguration
    {
        public static void AddRepositoriesCollections(this IServiceCollection service)
        {
            service.AddScoped<IBaseRepository<Permissions>, PermissionsRepository>();
            service.AddScoped<IBaseRepository<TypePermissions>, TypePermissionsRepository>();
        }
    }
}
