using Microsoft.AspNetCore.Mvc;
using Proj.Domain.Entities;
using Proj.Repository.Interfaces;

namespace Proj.Web.Controllers
{
    public class ContaRestauranteController : Controller
    {
        private IContaRestauranteRepository contaRestauranteRepository;
        private IRestauranteRepository restauranteRepository;

        public ContaRestauranteController(IContaRestauranteRepository contaRestauranteRepository, IRestauranteRepository restauranteRepository)
        {
            this.contaRestauranteRepository = contaRestauranteRepository;
            this.restauranteRepository = restauranteRepository;
        }

        public IActionResult Index()
        {
            ViewBag.menorPreco = contaRestauranteRepository.GetMenorPreco();
            ViewBag.maiorPreco = contaRestauranteRepository.GetMaiorPreco();
            return View(contaRestauranteRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            ViewBag.Restaurantes = restauranteRepository.GetAll();
            return View(contaRestauranteRepository.GetByID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Restaurantes = restauranteRepository.GetAll();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaRestaurante entity)
        {   //resolver problema na entidade restaurante
            entity.restaurante = restauranteRepository.GetByID(entity.restaurante.id);
            contaRestauranteRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.restaurante = restauranteRepository.GetAll();
            return View(contaRestauranteRepository.GetByID(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(ContaRestaurante entity)
        {
            entity.restaurante = restauranteRepository.GetByID(entity.restaurante.id);
            contaRestauranteRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            contaRestauranteRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
