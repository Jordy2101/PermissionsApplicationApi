using PermissionsApplication.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.TypePermission.GetListTypePermissions
{
    public interface IGetListTypePermissionsQueries
    {
        Task<IEnumerable<TypePermissionsDto>> GetListTypePermissions();
    }
}
