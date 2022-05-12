using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Contracts
{
    public interface IProjectRepository
    {
        public IEnumerable<Project> GetAllProjects(bool trackChanges);

        public Project GetOneProjectById(Guid projectId, bool trackChanges);

        public void CreateProject(Project project);

        public void DeleteProject(Project project);
    }
}