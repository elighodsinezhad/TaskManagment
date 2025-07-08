using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.Domain.Tasks
{
   public class AssignTask
    {
        [Required]
        [Range(1,int.MaxValue)]
        public int TaskId { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int PersonId { get; set; }
    }
}
