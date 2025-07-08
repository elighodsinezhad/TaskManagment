using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Projects;

namespace TaskManagement.Infra.Data.EF.SqlServer.Projects
{
   public interface IProjectRepository
    {
        List<Project> GetProjects();
        Project GetById(int id);
    }
}
