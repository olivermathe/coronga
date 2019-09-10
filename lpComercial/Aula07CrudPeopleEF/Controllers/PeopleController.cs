using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula07CrudPeopleEF.Models;

namespace Aula07CrudPeopleEF.Controllers
{
    public class PeopleController : Controller
    {
        private IpersonRepository pRepository;
        public IActionResult Index()
        {
            var people = pRepository.GetAll();
            return View(people);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (Person person)
        {
            pRepository.Create(person);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
