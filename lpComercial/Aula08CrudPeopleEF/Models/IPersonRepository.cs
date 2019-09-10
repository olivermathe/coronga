using System.Collections.Generic;

namespace Aula08CrudPeopleEF.Models
{
    public interface IPersonRepository
    {
         void Create(Person person);
         void Update(Person person);
         void Delete(int id);
         List<Person> GetAll();
         Person GetByID(int id);


    }
}