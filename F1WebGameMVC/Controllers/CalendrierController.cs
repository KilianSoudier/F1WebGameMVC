using F1WebGameMVC.Models.PODO;
using F1WebGameMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1WebGameMVC.Controllers
{
    public class CalendrierController : Controller
    {
        private readonly CircuitServices circuitService;

        public CalendrierController()
        {
            circuitService = new CircuitServices();
        }
        public IActionResult Index()
        {
            int saisonId = Convert.ToInt32(Request.Cookies["idSaison"]);
            ViewBag.Circuits = circuitService.getAllCircuits(saisonId); ;
            return View();
        }
    }
}
