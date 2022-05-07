using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManagement.Entities.Models;

namespace ProjectManagement.Repository.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = new Guid("82b3ea85-adfd-4641-8bf2-b5c3d5479c0a"),
                    ProjectId = new Guid("105ebb0f-bc6d-44ae-be34-9064cb6a9629"),
                    FirstName = "Mahmut",
                    LastName = "Tuncer",
                    Age = 31,
                    Position = "Senior Developer",
                }
                );
        }
    }
}