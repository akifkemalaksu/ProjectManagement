using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Contracts.Repository.Repositories
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetAllProjects(bool trackChanges);

        Project GetProject(Guid projectId, bool trackChanges);

        void CreateProject(Project project);

        void DeleteProject(Project project);
    }
}