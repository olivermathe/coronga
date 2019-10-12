using System.Collections.Generic;
using System.Linq;

namespace TarefasArnaldo.Models
{
    public class TaskRepository : ITaskRepository
    {
        private DataContext context ;

        public TaskRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Task task)
        {
            context.TarefasArnaldo.Add(task);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.TarefasArnaldo.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Task> Getall()
        {
            return context.TarefasArnaldo.ToList(); 
        }

        public Task GetById(int id)
        {
            return context.TarefasArnaldo.SingleOrDefault(x=>x.id == id);
        }

        public void Update(Task task)
        {
            var objTask = GetById(task.id);
            objTask.name = task.name;
            objTask.date = task.date;
            objTask.percentComplete = task.percentComplete;

            context.SaveChanges();
        }
    }
}