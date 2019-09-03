using System;
using System.Collections.Generic;
namespace TarefaController.Models
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
        public Tarefa GetByPrioridade (int prioridade)
        {
            return tarefas.Find(x=>x.prioridade == prioridade);
        }
        internal void Edit (int prioridade)
        {
            throw new NotImplementedException();
        }
        public void Delete(int prioridade)
        {
            tarefas.Remove(GetByPrioridade(prioridade));
        }
        public void Update (Tarefa tarefa)
        {
            var index = tarefas.FindIndex(x=>x.prioridade==tarefa.prioridade);
            tarefas[index].tarefaNome=tarefa.tarefaNome;
            tarefas[index].prioridade=tarefa.prioridade;
            tarefas[index].dataLimite=tarefa.dataLimite;
            tarefas[index].percentConcluido=tarefa.percentConcluido;
        }
    }
}
