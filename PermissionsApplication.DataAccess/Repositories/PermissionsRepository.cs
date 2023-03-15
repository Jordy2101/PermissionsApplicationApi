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
    public class PermissionsRepository : BaseRepository<Permissions>
    {
        public PermissionsRepository(PermissionsApplicationContext ctx) : base(ctx)
        {

        }
    }
}
