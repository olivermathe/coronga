using System.Collections.Generic;
using System.Linq;
using Aula08CrudPeopleEF.Models;

namespace Aula08CrudPeopleEF.Models
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
        }
        public List<Person> GetAll()
        {
            return context.People.ToList();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }



        public Person GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}