using ProjectManagement.Contracts.Repository.Repositories;
using System;

namespace ProjectManagement.Contracts.Repository.UoW
{
    public interface IRepositoryManager
    {
        IProjectRepository Project { get; }
        IEmployeeRepository Employee { get; }

        void Save();
    }
}