using System.Collections.Generic;
using System.Linq;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;
using restaurante.domain;

namespace Proj.Repository.Repositories
{
    public class RestauranteRepository : IRestauranteRepository
    {
        DataContext context;

        public RestauranteRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Restaurante obj)
        {
            context.Restaurantes.Add(obj);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.Restaurantes.Remove(this.GetByID(id));
            context.SaveChanges();      
        }
        public List<Restaurante> GetAll()
        {
            return context.Restaurantes.ToList();
        }
        public Restaurante GetByID(int id)
        {
            return context.Restaurantes.SingleOrDefault(x=>x.id == id);
        }

        public void Update(Restaurante entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
