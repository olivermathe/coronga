using AppTarefa.Models;
using Microsoft.AspNetCore.Mvc;
namespace AppTarefas.Controllers
{
    public class TarefasController : Controller
    {
        TarefasRepository _repository = new TarefasRepository();
        public IActionResult Index()
        {
         /*var é pra quando nao sabe o tipo */ 
           var tarefas = _repository.GetAll();   //esta buscando todos os elementos da lista person
            return View(tarefas); //depois mandar para o metodo view
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
       public IActionResult Edit(int id)
        {
            var tar = _repository.GetById(id);
            return View(tar);   
        }
        [HttpPost]
        public IActionResult Edit(Tarefa tarefaAlterada)
        {
            _repository.Update(tarefaAlterada);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }   
    }
}
