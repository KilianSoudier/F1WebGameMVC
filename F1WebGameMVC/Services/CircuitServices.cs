using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class CircuitServices
    {
        private readonly Context ctx=new Context();
        private readonly VoitureServices voitureServices = new VoitureServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly ClassementServices classementServices = new ClassementServices();
        private readonly CoursesServices courseServices = new CoursesServices();
        private readonly SaisonServices saisonServices = new SaisonServices();

        public List<Circuit> getAllCircuits(int idSaison)
        {
            return ctx.Circuit.Where(s => s.saison.idSaison == idSaison).OrderBy(s => s.ordre).ToList();
        }
        public Circuit? getCircuitByOrdre(int idSaison, int ordre)
        {

        }
    }
}
