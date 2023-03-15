using PermissionsApplication.DataAccess.Context;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.DataAccess.Repositories
{
    public class TypePermissionsRepository : BaseRepository<TypePermissions>
    {
        public TypePermissionsRepository(PermissionsApplicationContext ctx) : base(ctx)
        {

        }
    }
}
