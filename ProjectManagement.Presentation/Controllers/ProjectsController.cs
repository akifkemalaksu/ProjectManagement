using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Service.Contracts;
using System;

namespace ProjectManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProjectsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var projects = _serviceManager.ProjectService.GetAllProjects(false);
            return Ok(projects);
        }

        [HttpGet("{projectId:guid}")]
        public IActionResult GetOneProjectById(Guid projectId)
        {
            var project = _serviceManager.ProjectService.GetOneProjectById(projectId, false);
            return Ok(project);
        }
    }
}