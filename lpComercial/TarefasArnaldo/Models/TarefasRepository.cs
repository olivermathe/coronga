using System.Collections.Generic;
using System.Linq;
namespace TarefasArnaldo.Models
{
       public class TarefasRepository : ITarefasRepository
    {
        private DataContext context; 
        public TarefasRepository(DataContext context)
        {
            this.context = context ;
        }
        List<Tarefas> ITarefasRepository.Getall => throw new System.NotImplementedException();

        public void Create(Tarefas tarefas)
        {
            context.TarefasArnaldo.Add(tarefas);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.TarefasArnaldo.Remove(GetById(id));
            context.SaveChanges();
        }
        public List<Tarefas> Getall ()
        {
            return context.TarefasArnaldo.ToList();
        }
        public Tarefas GetById(int id)
        {
            return context.TarefasArnaldo.SingleOrDefault(x=>x.id == id);
        }
        public void Update(Tarefas tarefas)
        {
            var objTarefas = GetById(tarefas.id);
            objTarefas.name = tarefas.name;
            objTarefas.dataLimite = tarefas.dataLimite;
            objTarefas.percentConcluido = tarefas.percentConcluido;
            
            context.SaveChanges();
        }
    }
}