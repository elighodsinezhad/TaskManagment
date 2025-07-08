using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Framework;

namespace TaskManagement.Core.Domain.Persons
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonRole Role { get; set; }
        public List<PersonProject> PersonProjects { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
