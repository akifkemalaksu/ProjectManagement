using ProjectManagement.Contracts;
using ProjectManagement.Service.Contracts;
using System;

namespace ProjectManagement.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProjectService> _projectService;
        private readonly Lazy<IEmployeeService> _employeeService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _projectService = new Lazy<IProjectService>(() => new ProjectService(repositoryManager, loggerManager));
            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, loggerManager));
        }

        public IProjectService ProjectService => _projectService.Value;

        public IEmployeeService EmployeeService => _employeeService.Value;
    }
}