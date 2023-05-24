using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;
using F1WebGameMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F1WebGameMVC.Controllers
{
    public class EquipeController : Controller
    {
        private readonly VoitureServices VoitureServices;
        public EquipeController()
        {
            VoitureServices= new VoitureServices();
        }

        // GET: EquipeController
        public ActionResult Index()
        {
            int saisonId = Convert.ToInt32(Request.Cookies["idSaison"]);
            ViewBag.voiture= VoitureServices.getAllVoitures(saisonId);

            return View("Index");
        }

        // GET: EquipeController/Details/5
        public ActionResult Details(int id)
        {
            Voiture v = VoitureServices.getUneVoiture(id);
            ViewBag.voiture = v;
            return View();
        }
        [HttpPost]
        public void annulerChoixEquipe()
        {
            Response.Cookies.Delete("idVoiture");
        }

        [HttpPost]
        public void enregistrerChoixVoiture(int idVoiture)
        {
            Response.Cookies.Append("idVoiture", idVoiture.ToString());
        }
    }
}
