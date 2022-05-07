using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities.Models;
using System;

namespace ProjectManagement.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}