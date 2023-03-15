using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Common.Dto;
using PermissionsApplication.Common.Filter;
using PermissionsApplication.Common.Paged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.PagedPermissions
{
    public interface IPagedPermissionsQueries
    {
        Task<Pagination<PermissionsDto>> GetPagedPermissions(PermissionsFilter filter);
    }
}
