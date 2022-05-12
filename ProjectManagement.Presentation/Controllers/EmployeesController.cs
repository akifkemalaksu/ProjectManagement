using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Service.Contracts;
using System;

namespace ProjectManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/projects/{projectId}/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public EmployeesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetAllEmployeesByProjectId(Guid projectId)
        {
            try
            {
                var employeeList = _serviceManager.EmployeeService.GetAllEmployeesByProjectId(projectId, false);
                return Ok(employeeList);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal service error!");
            }
        }

        [HttpGet("{employeeId:guid}")]
        public IActionResult GetOneEmployeeByProjectId(Guid projectId, Guid employeeId)
        {
            try
            {
                var employee = _serviceManager.EmployeeService.GetOneEmployeeByProjectId(projectId, employeeId, false);
                return Ok(employee);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal service error!");
            }
        }
    }
}