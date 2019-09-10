using System.Collections.Generic;

namespace Aula07CrudPeopleEF.Models
{
    public interface IpersonRepository
    {
        void Create (Person person);
        void Update (Person person);
        void Delete(int id);
        List<Person> GetAll();
        Person GetByID (int id); 
    }
}