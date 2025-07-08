using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.Core.Contracts.Tasks.Commands
{
    public class CreateTask
    {
        [StringLength(100, MinimumLength = 20)]
        public string ShortDescription { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 20)]
        public string Description { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int ProjectId { get; set; }
        public int? PersonId { get; set; }

    }
}
