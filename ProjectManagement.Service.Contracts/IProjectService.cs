using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Service.Contracts
{
    public interface IProjectService
    {
        public IEnumerable<Project> GetAllProjects(bool trackChanges);
    }
}