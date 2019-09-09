using AppPeople.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPeople.Controllers
{

    public class PeopleController : Controller
    {
        PersonRepository _repository = new PersonRepository(); //instanciou todos os metodos para acessar todas os metódos das pessoas

        public IActionResult Index()
        {
            var people = _repository.GetAll();
            return View(people); //metodo view vai buscar 
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (Person person)
        {
            _repository.Create(person);
            
            return RedirectToAction("index");
        }
        public IActionResult Edit(Person personAlterado)
        {
            _repository.Update(personAlterado);
            return RedirectToActionPermanent("index");
        }
        public  IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}