using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proj.Domain.Entities;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;

namespace Proj.Repository.Repository
{
    public class ContaRestauranteRepository : IContaRestauranteRepository
    {
        private DataContext context;

        public ContaRestauranteRepository (DataContext context)
        {
            this.context = context;
        }

        public ContaRestaurante GetByID(int id)
        {
            return context.ContasRestaurante.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<ContaRestaurante> GetAll()
        {                                              //ver se não vai bugar com o x.id
            return context.ContasRestaurante.Include(x=>x.id).ToList().OrderBy(x => x.id);
        }

        public void Create(ContaRestaurante nome)
        {
            context.Entry(nome).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(ContaRestaurante nome)
        {
            context.Entry(nome).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.ContasRestaurante.Remove(this.GetByID(id));
            context.SaveChanges();
        }

        public ContaRestaurante GetMenorPreco()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.kgGasto).First() : null;
        }

        public ContaRestaurante GetMaiorPreco()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.kgGasto).Last() : null;
        }
    }
}