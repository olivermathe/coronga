using TarefaController.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TarefaController.Controllers
{
    public class TarefaController : Controller
    {
        TarefaController _repository = new TarefaController();
        public IActionResult Index()
        {
         /*var é pra quando nao sabe o tipo */ 
           var tarefas = _repository.GetAll();   //esta buscando todos os elementos da lista person
            return View(tarefas); //depois mandar para o metodo view
        }
        private object GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _repository.Create(tarefa);

            return RedirectToAction("index");
        }
       public IActionResult Edit(int prioridade)
        {
            var tarefas = _repository.GetByPrioridade(prioridade);
            return View(tarefas);   
        }

        private object GetByPrioridade(int prioridade)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Edit(Tarefa tarefaAlterada)
        {
            _repository.Update(tarefaAlterada);
            return RedirectToAction("index");
        }
        private void Update(Tarefa tarefaAlterada)
        {
            throw new NotImplementedException();
        }
        public IActionResult Delete(int prioridade)
        {
            _repository.Delete(prioridade);
            return RedirectToAction("Index");
        }   
    }
}
