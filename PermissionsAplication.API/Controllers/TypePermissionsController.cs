using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermissionsApplication.Application.Features.TypePermission.GetListTypePermissions;

namespace PermissionsAplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypePermissionsController : ControllerBase
    {
        readonly IGetListTypePermissionsQueries _service;
        public TypePermissionsController(IGetListTypePermissionsQueries service)
        {
            _service = service;
        }

        [HttpGet("GetListTypePermissions")]
        public IActionResult GetListTypePermissions() => Ok(_service.GetListTypePermissions().Result);
    }
}
