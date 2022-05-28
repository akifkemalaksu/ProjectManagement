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
            var employeeList = _serviceManager.EmployeeService.GetAllEmployeesByProjectId(projectId, false);
            return Ok(employeeList);
        }

        [HttpGet("{employeeId:guid}")]
        public IActionResult GetOneEmployeeByProjectId(Guid projectId, Guid employeeId)
        {
            var employee = _serviceManager.EmployeeService.GetOneEmployeeByProjectId(projectId, employeeId, false);
            return Ok(employee);
        }
    }
}