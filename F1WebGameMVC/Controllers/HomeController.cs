using F1WebGameMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1WebGameMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SaisonServices _saisonServices;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _saisonServices = new SaisonServices();
        }

        public IActionResult Index()
        {
            ViewBag.Saisons = _saisonServices.listeDeroulanteIndex(_saisonServices.getAllSaisons());
            return View();
        }
        [HttpPost]
        public void nouvellePartie(int saisonId)
        {
            Response.Cookies.Append("idSaison", saisonId.ToString());
        }
    }
}