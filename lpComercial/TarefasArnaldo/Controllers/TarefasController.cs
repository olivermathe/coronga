using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TarefasArnaldo.Models;

namespace TarefasArnaldo.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}