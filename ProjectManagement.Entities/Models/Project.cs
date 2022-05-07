using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagement.Entities.Models
{
    public class Project
    {
        [Column("ProjectId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Project name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length of the name is 60 characters.")]
        public string Name { get; set; }

        public string? Description { get; set; }
        public string? Field { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}