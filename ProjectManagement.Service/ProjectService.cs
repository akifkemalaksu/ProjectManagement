using AutoMapper;
using ProjectManagement.Contracts;
using ProjectManagement.Entities.Exceptions;
using ProjectManagement.Service.Contracts;
using ProjectManagement.Shared.DataTransferObjects;
using System;

namespace ProjectManagement.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public ProjectService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<ProjectDto> GetAllProjects(bool trackChanges)
        {
            var projects = _repositoryManager.Project.GetAllProjects(trackChanges);
            var projectDtos = _mapper.Map<IEnumerable<ProjectDto>>(projects);
            return projectDtos;
        }

        public ProjectDto GetOneProjectById(Guid id, bool trackChanges)
        {
            var project = _repositoryManager.Project.GetOneProjectById(id, trackChanges);

            if (project is null)
                throw new ProjectNotFoundException(id);

            var projectDto = _mapper.Map<ProjectDto>(project);
            return projectDto;
        }
    }
}