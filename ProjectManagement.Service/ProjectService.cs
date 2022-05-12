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
            try
            {
                var projects = _repositoryManager.Project.GetAllProjects(trackChanges);
                return projects;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"PRojectService.GetAllProjects() has an error: {ex.Message}");
                throw;
            }
        }

        public Project GetOneProjectById(Guid id, bool trackChanges)
        {
            try
            {
                var project = _repositoryManager.Project.GetOneProjectById(id, trackChanges);
                return project;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"ProjectRepository.GetProject() has an error: {ex.Message}");
                throw;
            }
        }
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;

        public EmployeeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Employee> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges)
        {
            try
            {
                var employeeList = _repositoryManager.Employee.GetEmployeesByProjectId(projectId, trackChanges);
                return employeeList;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"IEmployeeRepository.GetEmployeesByProjectId() has an error: {ex.Message}");
                throw;
            }
        }

        public Employee GetOneEmployeeByProjectId(Guid projectId, Guid employeeId, bool trackChanges)
        {
            try
            {
                var project = _repositoryManager.Employee.GetEmployeeByProjectId(projectId, employeeId, trackChanges);
                return project;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"IEmployeeRepository.GetEmployeeByProjectId() has an error: {ex.Message}");
                throw;
            }
        }
    }
}