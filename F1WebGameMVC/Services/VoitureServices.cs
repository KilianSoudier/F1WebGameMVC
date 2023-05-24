using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class VoitureServices
    {
        private readonly Context ctx = new Context();
        private readonly CircuitServices circuitServices = new CircuitServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly ClassementServices classementServices = new ClassementServices();
        private readonly CoursesServices courseServices = new CoursesServices();
        private readonly SaisonServices saisonServices = new SaisonServices();

        public List<Voiture> getAllVoitures(int idSaison)
        {
            List<Voiture> voitures = ctx.Voiture.Where(s => s.saison.idSaison == idSaison).OrderBy(s => s.ecurie.ordre).ToList();
            return voitures;
        }
        public Voiture getUneVoiture(int idVoiture)
        {
            return ctx.Voiture.SingleOrDefault(s => s.idVoiture == idVoiture);
        }
    }
}
