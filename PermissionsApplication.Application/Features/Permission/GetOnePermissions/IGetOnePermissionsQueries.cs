using PermissionsApplication.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.GetOnePermissions
{
    public interface IGetOnePermissionsQueries
    {
        Task<PermissionsDto> GetOnePemissions(int id);
    }
}
