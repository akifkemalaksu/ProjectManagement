using ProjectManagement.Contracts.Repository.Repositories;
using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Repository.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmployeeForProject(Guid projectId, Employee employee)
        {
            employee.ProjectId = projectId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public Employee GetEmployeeByProjectId(Guid projectId, int employeeId, bool trackChanges) =>
            FindByCondition(e => e.ProjectId.Equals(projectId) && e.Id.Equals(employeeId), trackChanges).SingleOrDefault();

        public IEnumerable<Employee> GetEmployeesByProjectId(Guid projectId, bool trackChanges) =>
            FindByCondition(e => e.Project.Equals(projectId), trackChanges).OrderBy(e => e.FirstName).ToList();
    }
}