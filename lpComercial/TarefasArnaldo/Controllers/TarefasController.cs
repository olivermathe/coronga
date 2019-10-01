using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TarefasArnaldo.Models;
//implementar os metodos para depois implementar na view 
namespace TarefasArnaldo.Controllers
{
    public class TarefasController : Controller
    {
        private ITarefasRepository repository;
        public TarefasController(ITarefasRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        { 
            var listPeople = repository.Getall();

            return View(listPeople);
        }
         public IActionResult Create() //esse ja serve como get
        { 
            return View();
        }
        [HttpPost]
         public IActionResult Create(Tarefas tarefas) //fazer assinatura com http post 
        { 
            repository.Create(tarefas);
            return RedirectToAction("Index");
        }
         public IActionResult Edit()
        { 
            return View();
        } 
         public IActionResult Edit(Tarefas tarefas)
        { 
            repository.Update(tarefas);

            return RedirectToAction("Index");
        }
          public IActionResult Delete(int id)
        { 
            repository.Delete(id);
            return View();
        }     
    }
}
