using AutoMapper;
using ProjectManagement.Contracts;
using ProjectManagement.Service.Contracts;
using ProjectManagement.Shared.DataTransferObjects;

namespace ProjectManagement.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public EmployeeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges)
        {
            try
            {
                var employeeList = _repositoryManager.Employee.GetEmployeesByProjectId(projectId, trackChanges);
                var employeeDtoList = _mapper.Map<IEnumerable<EmployeeDto>>(employeeList);
                return employeeDtoList;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"IEmployeeRepository.GetEmployeesByProjectId() has an error: {ex.Message}");
                throw;
            }
        }

        public EmployeeDto GetOneEmployeeByProjectId(Guid projectId, Guid employeeId, bool trackChanges)
        {
            try
            {
                var employee = _repositoryManager.Employee.GetEmployeeByProjectId(projectId, employeeId, trackChanges);
                var employeeDto = _mapper.Map<EmployeeDto>(employee);
                return employeeDto;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"IEmployeeRepository.GetEmployeeByProjectId() has an error: {ex.Message}");
                throw;
            }
        }
    }
}