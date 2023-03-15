using PermissionsApplication.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.CreatePermissions
{
    public interface ICreatePermissionsCommand
    {
        Task CreatePermission(PermissionsDto dto);
    }
}
