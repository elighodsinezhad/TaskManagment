using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Framework;
using TaskManagement.Core.Domain.Projects;

namespace TaskManagement.Core.Domain.Persons
{
  public  class PersonProject:BaseEntity
    {
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
