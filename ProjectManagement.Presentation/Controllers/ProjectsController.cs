using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities.Models;
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
            try
            {
                var projects = _serviceManager.ProjectService.GetAllProjects(false);
                return Ok(projects);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error!");
            }
        }

        [HttpGet("{projectId:guid}")]
        public IActionResult GetOneProjectById(Guid projectId)
        {
            try
            {
                Project project = _serviceManager.ProjectService.GetOneProjectById(projectId, false);
                return Ok(project);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error!");
            }
        }
    }
}