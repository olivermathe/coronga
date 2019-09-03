using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula04MVC.Models;
using System.Collections.Generic;

namespace Aula04MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Conta> contas = new List<Conta>();
            contas.Add(new Conta(){id=1,titular="João"});
            contas.Add(new Conta(){id=2,titular="Aline"});
            contas.Add(new Conta(){id=3,titular="Silva"});


            return View(contas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
