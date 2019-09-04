using System;
using System.Collections.Generic;
namespace TarefasController.Models
{
    public class TarefaRepository
    {
        public static List<Tarefa> tarefas = new List<Tarefa>();

        public TarefaRepository() 
        {}
        public void Create (Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }
        public List<Tarefa> GetAll()
        {
            return tarefas;
        }
        /* public Tarefa GetByPrioridade (int prioridade)
        {
            return tarefa.Find(x=>x.prioridade == prioridade);
        }*/
        public Tarefa GetById (int id)
        {
            return tarefas.Find(x=>x.id == id);
        }
        internal void Edit (int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            tarefas.Remove(GetById(id));
        }
        public void Update (Tarefa tarefa)
        {
            var index = tarefas.FindIndex(x=>x.id==tarefa.id);
            tarefas[index].tarefaNome=tarefa.tarefaNome;
            tarefas[index].id=tarefa.id;
            tarefas[index].dataLimite=tarefa.dataLimite;
            tarefas[index].percentConcluido=tarefa.percentConcluido;
        }
    }
}
