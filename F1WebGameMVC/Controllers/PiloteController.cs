using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;
using F1WebGameMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1WebGameMVC.Controllers
{
    public class PiloteController : Controller
    {
        private readonly VoitureServices VoitureServices;

        public PiloteController()
        {
            VoitureServices = new VoitureServices();
        }

        public IActionResult Index()
        {
            int idVoiture= Convert.ToInt32(Request.Cookies["idVoiture"]);
            ViewBag.voiture = VoitureServices.getUneVoiture(idVoiture);

            return View();
        }

        public void annulerChoixEquipe()
        {
            Response.Cookies.Delete("idVoiture");
        }
    }
}
