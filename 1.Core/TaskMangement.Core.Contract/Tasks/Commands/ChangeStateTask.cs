using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMangement.Core.Contracts.Tasks.Commands
{
   public class ChangeStateTask
    {
        public int TaskId { get; set; }
        public TaskStatus Status { get; set; }
    }
}
