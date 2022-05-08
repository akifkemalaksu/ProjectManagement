using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Service.Contracts;

namespace ProjectManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProjectsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _serviceManager.ProjectService.GetAllProjects(false);
            return Ok(list);
        }
    }
}