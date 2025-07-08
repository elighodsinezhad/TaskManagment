using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Framework;
using TaskManagement.Core.Domain.Persons;
using TaskManagement.Core.Domain.Projects;

namespace TaskManagement.Core.Domain.Tasks
{
   public class Task:BaseEntity 
    {
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Framework.TaskStatus Status { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        
    }
}
