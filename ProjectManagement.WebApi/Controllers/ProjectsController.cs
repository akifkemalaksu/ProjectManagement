using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Contracts.Utilities.Logger;
using ProjectManagement.Entities.Models;

namespace ProjectManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly List<Project> _projectList;
        private readonly ILoggerService _loggerService;

        public ProjectsController(ILoggerService loggerService)
        {
            _loggerService = loggerService;

            _projectList = new List<Project>()
            {
                new Project(){ Id = Guid.NewGuid(),Name="Akif"},
                new Project(){ Id = Guid.NewGuid(),Name="Kemal"},
                new Project(){ Id = Guid.NewGuid(),Name="Aksu"}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                int a = 0;
                int b = 5;
                int c = b / a;
                _loggerService.LogInfo("Projects.Get() has been run.");
                return Ok(_projectList);
            }
            catch (Exception ex)
            {
                _loggerService.LogError($"Projects.Get() has been crashed : {ex.Message}");
                throw;
            }
        }
    }
}