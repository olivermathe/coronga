using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;
using restaurante.domain;

namespace Proj.Repository.Repositories
{
    public class ConsumoRepository : IConsumoRepository
    {
       private DataContext context;

        public ConsumoRepository (DataContext context)
        {
            this.context = context;
        }

        public Consumo GetByID(int id)
        {
            return context.Consumos.Include(x=>x.restaurante).SingleOrDefault(x => x.id == id);
        }

        
        public void Create(Consumo nome)
        {
            context.Entry(nome).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Consumo nome)
        {
            context.Entry(nome).State = EntityState.Modified;
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

        List<Consumo> IBaseRepository<Consumo>.GetAll()
        {
            return context.Consumos.Include(x=>x.restaurante).OrderBy(x => x.id).ToList();
        }

        public IEnumerable<Consumo> GetAll()
            {                                              //ver se não vai bugar com o x.id
                return context.Consumos.Include(x=>x.restaurante).ToList().OrderBy(x => x.id);
            }

    }
}