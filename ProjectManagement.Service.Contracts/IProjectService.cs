using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Service.Contracts
{
    public interface IProjectService
    {
        public IEnumerable<Project> GetAllProjects(bool trackChanges);

        public Project GetOneProjectById(Guid id, bool trackChanges);
    }

    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges);

        public Employee GetOneEmployeeByProjectId(Guid projectId, Guid employeeId, bool trackChanges);
    }
}