using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Domain.Persons;
using TaskManagement.Infra.Data.EF.SqlServer.Common;

namespace TaskManagement.Infra.Data.EF.SqlServer.Persons
{
    public class PersonRepository : IPersonReposotory
    {
        private readonly TaskDbContext _taskDbContext;

        public PersonRepository(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }
        public Person GetById(int id) => _taskDbContext.Persons.Where(i => i.Id == id).FirstOrDefault();

        public List<Person> GetPersons() => _taskDbContext.Persons.ToList();
    }
}
