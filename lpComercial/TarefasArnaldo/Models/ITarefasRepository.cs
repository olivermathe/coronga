using System.Collections.Generic;

namespace TarefasArnaldo.Models
{
    public interface ITarefasRepository
    {
         void Create (Tarefas tarefas);
         void Update(Tarefas tarefas);
         void Delete(int id);
         List<Tarefas> Getall();
    }
}