using ProjectManagement.Entities.Models;

namespace ProjectManagement.Contracts
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeesByProjectId(Guid projectId, bool trackChanges);

        public Employee GetEmployeeByProjectId(Guid projectId, Guid employeeId, bool trackChanges);

        public void CreateEmployeeForProject(Guid projectId, Employee employee);

        public void DeleteEmployee(Employee employee);
    }
}