using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Repository.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project
                {
                    Id = new Guid("105ebb0f-bc6d-44ae-be34-9064cb6a9629"),
                    Name = "ASP.NET Core Web API Project",
                    Description = "Web Application Programming Interface",
                    Field = "Computer Science"
                }
                );
        }
    }
}