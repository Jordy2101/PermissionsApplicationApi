using PermissionsApplication.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.UpdatePermissions
{
    public interface IUpdatePermissionsCommand
    {
        Task UpdatePermissions(PermissionsDto dto);
    }
}
