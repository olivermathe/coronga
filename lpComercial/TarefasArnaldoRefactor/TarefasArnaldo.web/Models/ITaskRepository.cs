using System.Collections.Generic;

namespace TarefasArnaldo.Models
{
    public interface ITaskRepository
    {
         void Create(Task task);
         void Update (Task task);
         void Delete (int id);
         Task GetById(int id);
         List<Task> Getall();
         
    }
}