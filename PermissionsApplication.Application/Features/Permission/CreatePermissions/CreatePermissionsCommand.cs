using PermissionsApplication.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.CreatePermissions
{
    public class CreatePermissionsCommand : ICreatePermissionsCommand
    {
        public CreatePermissionsCommand() { }
        public Task CreatePermission(PermissionsDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
