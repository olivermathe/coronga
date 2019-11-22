using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;
using Proj.Domain.Entities;
using System.Data.Entity;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace Proj.Repository.Repositories
{
    public class RestauranteRepository : IRestauranteRepository
    {
        DataContext context;
        public RestauranteRepository(DataContext context)
        {
            this.context = context;
        }
        public Restaurante GetByID(int id)
        {
            return context.Restaurantes.SingleOrDefault(x=>x.id == id);
        }

        public IEnumerable<Restaurante> GetAll()
        {
            return context.Restaurantes.ToList().OrderBy(x => x.id);
        }

        public void Create(Restaurante restaurante)
        {
            context.Entry(restaurante).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Restaurante restaurante)
        {
            context.Entry(restaurante).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
         context.Restaurantes.Remove(this.GetByID(id));
         context.SaveChanges();
        }
    }
}
