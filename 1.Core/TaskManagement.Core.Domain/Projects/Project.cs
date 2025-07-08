using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Framework;
using TaskManagement.Core.Domain.Persons;

namespace TaskManagement.Core.Domain.Projects
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
        public List<PersonProject> PersonProjects { get; set; }
    }
}
