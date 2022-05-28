using ProjectManagement.Shared.DataTransferObjects;

namespace ProjectManagement.Service.Contracts
{
    public interface IEmployeeService
    {
        public IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges);

        public EmployeeDto GetOneEmployeeByProjectId(Guid projectId, Guid employeeId, bool trackChanges);
    }
}