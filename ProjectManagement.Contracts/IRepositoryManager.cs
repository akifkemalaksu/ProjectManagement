using System;
using ProjectManagement.Contracts;

namespace ProjectManagement.Contracts
{
    public interface IRepositoryManager
    {
        IProjectRepository Project { get; }
        IEmployeeRepository Employee { get; }

        void Save();
    }
}
