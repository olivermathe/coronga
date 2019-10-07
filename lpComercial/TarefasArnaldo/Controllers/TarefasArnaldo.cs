namespace CrudEFCorePeopleVideoAula.Controllers
{
    using System.Diagnostics;
    using global::TarefasArnaldo.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    namespace TarefasArnaldo.Controllers
    {
        public class TarefasArnaldo : Controller
        {
        private ITaskRepository repository;    

        public TarefasArnaldo(ITaskRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var listTarefasArnaldo = repository.Getall();
            return View(listTarefasArnaldo);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] //vai receber via http o user que for cadastrado 
        public IActionResult Create(Task task)
        {
            repository.Create(task); // vai gravar no banco de dados 
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
             var task = repository.GetById(id);
            return View(task);
        }
        [HttpPost] //vai receber via http o user que for cadastrado para poder editar 
        public IActionResult Edit(Task task)
        {
            repository.Update(task); 
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            repository.Delete(id); 
            return RedirectToAction("Index");
        }

        }
    }
}

