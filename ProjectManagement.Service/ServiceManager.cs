using ProjectManagement.Contracts;
using ProjectManagement.Service.Contracts;
using System;

namespace ProjectManagement.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProjectService> _projectService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _projectService = new Lazy<IProjectService>(() => new ProjectService(repositoryManager, loggerManager));
        }

        public IProjectService ProjectService => _projectService.Value;
    }
}