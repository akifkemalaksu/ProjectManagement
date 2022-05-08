using ProjectManagement.Contracts;
using System;

namespace ProjectManagement.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IProjectRepository> _projectRepository;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _projectRepository = new Lazy<IProjectRepository>(() => new ProjectRepository(_repositoryContext));
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(_repositoryContext));
        }

        public IProjectRepository Project => _projectRepository.Value;

        public IEmployeeRepository Employee => _employeeRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}