using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Tasks;

namespace TaskManagement.Infra.Data.EF.SqlServer.Tasks
{
    interface ITaskRepository
    {
        bool AddTask(Core.Domain.Tasks.Task task);
        bool changeState(Core.Domain.Tasks.Task task);
        bool AssignTask(int taskId, int personId);
    }
}
