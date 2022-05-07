using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Contracts.Repository.UoW;
using ProjectManagement.Contracts.Utilities.Logger;

namespace ProjectManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ILoggerService _loggerService;
        private readonly IRepositoryManager _repositoryManager;

        public ProjectsController(ILoggerService loggerService, IRepositoryManager repositoryManager)
        {
            _loggerService = loggerService;
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var list = _repositoryManager.Project.GetAllProjects(false);
                return Ok(list);
            }
            catch (Exception ex)
            {
                _loggerService.LogError($"Projects.Get() has been crashed : {ex.Message}");
                throw;
            }
        }
    }
}