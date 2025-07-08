using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Persons;
using TaskManagement.Core.Domain.Projects;

namespace TaskManagement.Infra.Data.EF.SqlServer.Common
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<PersonProject> PersonProjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }



}
