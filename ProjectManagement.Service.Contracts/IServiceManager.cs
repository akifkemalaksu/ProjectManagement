using System;

namespace ProjectManagement.Service.Contracts
{
    public interface IServiceManager
    {
        public IProjectService ProjectService { get; }
        public IEmployeeService EmployeeService { get; }
    }
}