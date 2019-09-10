using System.Collections.Generic;
using System.Linq;

namespace Aula07CrudPeopleEF.Models
{
    public class PersonRepository : IpersonRepository
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
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return context.People.ToList();
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