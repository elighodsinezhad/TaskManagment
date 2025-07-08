using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Persons;

namespace TaskManagement.Infra.Data.EF.SqlServer.Persons
{
   public interface IPersonReposotory
    {
        List<Person> GetPersons();
        Person GetById(int id);
        int AssignPerson(Person person);
        

    }
}
