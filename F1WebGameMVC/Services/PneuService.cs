using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class PneuService
    {
        private readonly Context ctx = new Context();
        private readonly VoitureServices voitureServices = new VoitureServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly ClassementServices classementServices = new ClassementServices();
        private readonly CircuitServices circuitServices = new CircuitServices();
        private readonly SaisonServices saisonServices = new SaisonServices();
        private readonly CoursesServices courseServices = new CoursesServices();
        private readonly TourService tourService = new TourService();

        public List<Pneus> getAllPneusBySaison(int saisonId)
        {
            return ctx.Pneus.Where(s => s.Saison.idSaison == saisonId).ToList();
        }

        public Pneus getPneusAleatoire(Course c)
        {
            List<Pneus> lesPneusDispos = getAllPneusBySaison(c.saison.idSaison);
            Random random = new Random();
            return lesPneusDispos.OrderBy(p => random.Next()).FirstOrDefault();

        }
        public Pneus getPneuById(int idPneu)
        {
            return ctx.Pneus.Single(s => s.Id == idPneu);
        }
    }
}
