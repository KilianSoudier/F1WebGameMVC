using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;
using F1WebGameMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1WebGameMVC.Controllers
{
    public class ClassementController : Controller
    {
        private readonly ClassementServices classementServices;
        private readonly CircuitServices circuitServices;
        public ClassementController()
        {
            classementServices= new ClassementServices();
            circuitServices= new CircuitServices();
        }

        public IActionResult Index()
        {
            int idSaison = Convert.ToInt32(Request.Cookies["idSaison"]);
            List<Classements> p = classementServices.getClassements(idSaison);
            if(p.Count == 0)
            {
                new Classements().initialiserSaison(idSaison);
            }

            ViewBag.circuit = circuitServices.getAllCircuits(idSaison).OrderBy(s => s.ordre).ToList();
            ViewBag.pilote= p;
            return View();
        }
    }
}
