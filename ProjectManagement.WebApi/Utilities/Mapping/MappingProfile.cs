using AutoMapper;
using ProjectManagement.Entities.Models;
using ProjectManagement.Shared.DataTransferObjects;

namespace ProjectManagement.WebApi.Utilities.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectDto>();
            CreateMap<Employee, EmployeeDto>();
        }
    }
}