using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class ClassementServices
    {
        private readonly Context ctx = new Context();
        private readonly VoitureServices voitureServices = new VoitureServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly CircuitServices circuitServices = new CircuitServices();
        private readonly CoursesServices courseServices = new CoursesServices();
        private readonly SaisonServices saisonServices = new SaisonServices();

        public List<Classements> getClassements(int idSaison)
        {
            return ctx.Classement.Where(s => s.pilote.Voiture.saison.idSaison == idSaison).OrderByDescending(s => s.pointsPilotes).ToList();
        }
    }
}
