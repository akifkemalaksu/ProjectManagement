using ProjectManagement.Entities.Models;

namespace ProjectManagement.Contracts.Repository.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployeesByProjectId(Guid projectId, bool trackChanges);

        Employee GetEmployeeByProjectId(Guid projectId, int employeeId, bool trackChanges);

        void CreateEmployeeForProject(Guid projectId, Employee employee);

        void DeleteEmployee(Employee employee);
    }
}