using System;
using System.Collections.Generic;
using System.Linq;

namespace TarefasArnaldo.Models
{
    public class TarefasRepository : ITarefasRepository
    {
        private DataContext context;

        public TarefasRepository (DataContext context)
        {
            this.context = context;
        }
        public void Create(Tarefas tarefas)
        {
            context.Tarefas.Add(tarefas);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.Tarefas.Remove(GetById(id));
            context.SaveChanges();
        }
        private Tarefas GetById(int id)
        {
            return context.Tarefas.SingleOrDefault(x=>x.id ==id);
        }
        public List<Tarefas> Getall()
        {
            return context.Tarefas.ToList();
        }
        public void Update(Tarefas tarefas)
        {
            var objTarefas = GetById(tarefas.id);
            objTarefas.nome=tarefas.nome;
            objTarefas.percentConcluido=tarefas.percentConcluido;
            objTarefas.dataLimite=tarefas.dataLimite;
            
            context.SaveChanges();
        }
    }
}