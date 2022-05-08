using System;
using ProjectManagement.Contracts;
using ProjectManagement.Repository;

namespace ProjectManagement.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly IProjectRepository _projectRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _projectRepository = new ProjectRepository(_repositoryContext);
            _employeeRepository = new EmployeeRepository(_repositoryContext);
        }

        public IProjectRepository Project => _projectRepository;

        public IEmployeeRepository Employee => _employeeRepository;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
