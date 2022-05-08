using ProjectManagement.Contracts;
using ProjectManagement.Entities.Models;
using ProjectManagement.Service.Contracts;
using System;

namespace ProjectManagement.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;

        public ProjectService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Project> GetAllProjects(bool trackChanges)
        {
            var projects = _repositoryManager.Project.GetAllProjects(trackChanges);
            return projects;
        }
    }
}