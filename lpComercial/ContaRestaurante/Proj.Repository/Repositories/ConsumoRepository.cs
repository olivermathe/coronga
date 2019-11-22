using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;
using Proj.Domain.Entities;

namespace Proj.Repository.Repositories
{
    public class ConsumoRepository : IConsumoRepository
    {
        private DataContext context;

        public ConsumoRepository(DataContext context)
        {
            this.context = context;
        }
        public Consumo GetByID(int id)
        {
            return context.Consumos.SingleOrDefault(x => x.id == id);
        }
        public IEnumerable<Consumo> GetAll()
        {
            return context.Consumos.Include(x=>x.restaurante).ToList().OrderBy(x => x.id);
        }
     
        public void Create(Consumo restaurante)
        {
            context.Entry(restaurante).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Consumo restaurante)
        {
            context.Entry(restaurante).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Consumos.Remove(this.GetByID(id));
            context.SaveChanges();
        }

        public Consumo GetMenorPreco()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.valor).First() : null;
        }

        public Consumo GetMaiorPreco()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.valor).Last() : null;
        }
    }
}