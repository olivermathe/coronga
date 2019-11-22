using System.Collections.Generic;

namespace Proj.Repository.Interfaces
{ 
    public interface IBaseRepository<Entity> where Entity : class
    {
        Entity GetByID(int id);
        IEnumerable<Entity> GetAll();
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
    }
}
