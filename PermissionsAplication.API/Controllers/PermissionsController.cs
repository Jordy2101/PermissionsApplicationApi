using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Application.Features.Permission.CreatePermissions;
using PermissionsApplication.Application.Features.Permission.DeletePermissions;
using PermissionsApplication.Application.Features.Permission.GetOnePermissions;
using PermissionsApplication.Application.Features.Permission.PagedPermissions;
using PermissionsApplication.Application.Features.Permission.UpdatePermissions;
using PermissionsApplication.Common.Filter;

namespace PermissionsAplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        readonly ICreatePermissionsCommand _createCommand;
        readonly IDeletePermissionsCommand _deleteCommand;
        readonly IGetOnePermissionsQueries _getOneCommand;
        readonly IPagedPermissionsQueries _pagedCommand;
        readonly IUpdatePermissionsCommand _updateCommand;
        public PermissionsController(ICreatePermissionsCommand createCommand, IDeletePermissionsCommand deleteCommand, 
                                     IGetOnePermissionsQueries getOneCommand, IPagedPermissionsQueries pagedCommand, IUpdatePermissionsCommand updateCommand)
        {
            _createCommand = createCommand;
            _deleteCommand = deleteCommand;
            _getOneCommand = getOneCommand;
            _pagedCommand = pagedCommand;
            _updateCommand = updateCommand;
        }

        [HttpPost("CreatePermission")]
        public IActionResult CreatePermisssion( [FromBody] PermissionsDto dto) => Ok(_createCommand.CreatePermission(dto));

        [HttpDelete("DeletePermissions/{id}")]
        public IActionResult DeletePermissions(int id) => Ok(_deleteCommand.DeletePermissions(id));

        [HttpGet("GetOne/{id}")]
        public IActionResult GetOne(int id) => Ok(_getOneCommand.GetOnePemissions(id));

        [HttpGet("GetPaged")]
        public IActionResult GetPaged([FromQuery] PermissionsFilter filter) => Ok(_pagedCommand.GetPagedPermissions(filter));

        [HttpPut("UpdatePermission")]
        public IActionResult UpdatePermission(PermissionsDto dto) => Ok(_updateCommand.UpdatePermissions(dto));
    }
}
