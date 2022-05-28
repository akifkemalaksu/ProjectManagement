using ProjectManagement.Shared.DataTransferObjects;
using System;

namespace ProjectManagement.Service.Contracts
{
    public interface IProjectService
    {
        public IEnumerable<ProjectDto> GetAllProjects(bool trackChanges);

        public ProjectDto GetOneProjectById(Guid id, bool trackChanges);
    }
}