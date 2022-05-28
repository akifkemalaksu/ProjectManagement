using System;

namespace ProjectManagement.Shared.DataTransferObjects
{
    public record ProjectDto(Guid Id, string Name, string Description, string Field);
}