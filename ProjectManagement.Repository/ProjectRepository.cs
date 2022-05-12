using ProjectManagement.Contracts;
using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Repository
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProject(Project project) => Create(project);

        public void DeleteProject(Project project) => Delete(project);

        public IEnumerable<Project> GetAllProjects(bool trackChanges) => FindAll(trackChanges).OrderBy(p => p.Name).ToList();

        public Project GetOneProjectById(Guid projectId, bool trackChanges) => FindByCondition(p => p.Id.Equals(projectId), trackChanges).SingleOrDefault();
    }
}