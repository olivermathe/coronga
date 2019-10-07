namespace CrudEFCorePeopleVideoAula.Controllers
{
    using System.Diagnostics;
    using global::CrudEFCorePeopleVideoAula.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    namespace CrudEFCorePeopleVideoAula.Controllers
    {
        public class PeopleController : Controller
        {
        private IPersonRepository repository;    

        public PeopleController(IPersonRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var listPeople = repository.Getall();
            return View(listPeople);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] //vai receber via http o user que for cadastrado 
        public IActionResult Create(Person person)
        {
            repository.Create(person); // vai gravar no banco de dados 
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var person = repository.GetById(id);
            return View(person);
        }
        [HttpPost] //vai receber via http o user que for cadastrado para poder editar 
        public IActionResult Edit(Person person)
        {
            repository.Update(person); 
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

