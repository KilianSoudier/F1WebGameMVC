using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class PiloteServices
    {
        private readonly Context ctx = new Context();
        private readonly VoitureServices voitureServices=new VoitureServices();
        private readonly ClassementServices classementServices=new ClassementServices();
        private readonly CoursesServices courseServices=new CoursesServices();
        private readonly SaisonServices saisonServices=new SaisonServices();
        private readonly CircuitServices circuitServices=new CircuitServices();

        public List<Pilote> getPilotesBySaison(int idSaison)
        {
            List<int> lesidVoitures = voitureServices.getAllVoitures(idSaison).Select(s=>s.idVoiture).ToList();
            return ctx.Pilote.Where(s => lesidVoitures.Contains(s.Voiture.idVoiture)).ToList();
        }

        public List<Pilote> getPilotesWithoutMyTeam(Voiture myTeam)
        {
            return ctx.Pilote.Where(s => s.Voiture.saison.idSaison == myTeam.saison.idSaison && s.Voiture.idVoiture != myTeam.idVoiture).ToList();
        }

        public List<Pilote> getOnlyMesPilotes(Voiture myTeam)
        {
            return ctx.Pilote.Where(s => s.Voiture.idVoiture == myTeam.idVoiture).ToList();
        }
        public Pilote getPiloteById(int idPilote)
        {
            return ctx.Pilote.Single(s=>s.idPilote== idPilote); 
        }
    }
}
