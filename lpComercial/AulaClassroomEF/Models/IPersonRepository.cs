using System.Collections.Generic;

namespace AulaClassroomEF.Models
{
    public interface IPersonRepository
    {
         void Create(Person person);

         void Update (Person person);

         void Delete(int id);

         void GetById(int id);

         List<Person> Getall(); 
    }
}