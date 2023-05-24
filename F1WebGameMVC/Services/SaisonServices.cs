using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace F1WebGameMVC.Services
{
    public class SaisonServices
    {
        private readonly Context ctx = new Context();
        private readonly VoitureServices voitureServices = new VoitureServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly ClassementServices classementServices = new ClassementServices();
        private readonly CoursesServices courseServices = new CoursesServices();
        private readonly CircuitServices circuitServices = new CircuitServices();
        public List<Saison> getAllSaisons()
        {
            List<Saison> res = ctx.Saison.OrderBy(s => s.libelleSaison).ToList();
            return res;
        }

        public List<SelectListItem> listeDeroulanteIndex(List<Saison> saisons)
        {
            string res = "";
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Value = "0", Text = "Veuillez choisir une saison" });
            foreach (Saison saison in saisons)
            {
                list.Add(new SelectListItem { Value = saison.idSaison.ToString(), Text = saison.libelleSaison });
            }
            return list;
        }

        public Saison getSaisonById(int idSaison)
        {
            return ctx.Saison.Where(s => s.idSaison == idSaison).SingleOrDefault();
        }
    }
}
