using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class TourService
    {
        private readonly Context ctx = new Context();
        private readonly VoitureServices voitureServices = new VoitureServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly ClassementServices classementServices = new ClassementServices();
        private readonly CircuitServices circuitServices = new CircuitServices();
        private readonly SaisonServices saisonServices = new SaisonServices();
        private readonly CoursesServices courseServices = new CoursesServices();
        private readonly PneuService pneuService = new PneuService();

        public Tour creerTour(Course c)
        {
            throw new NotImplementedException();
        }

        public Pneus getPneuById(int idPneu)
        {
            return ctx.Pneus.Single(s=>s.Id==idPneu);
        }

        public Tour initCourseUnPilote(Course c, Pilote pilote, Pneus pneu) 
        {
            Tour unTour = new Tour();
            unTour.pneus = pneu;
            unTour.erreurMajeure = false;
            unTour.usurePneus = 0;
            unTour.abandon = false;
            unTour.Course = c;
            unTour.Pilote = pilote;
            unTour.nb = 0;
            ctx.Add(unTour);
            ctx.SaveChanges();
            return unTour;
        }

        public bool verifTousPilotesPneusChoisis(Course c)
        {
            return c.tours.Count == c.pilotes.Count;
        }


        public List<Tour> initAutresPilotesCourse(Course c, int idVoiture)
        {
            List<Tour> res = new List<Tour>();
            List<Pilote> lesAutresPilotes = piloteServices.getPilotesWithoutMyTeam(voitureServices.getUneVoiture(idVoiture));
            foreach (Pilote unPilote in c.pilotes)
            {
                Tour unTour = new Tour();
                unTour.pneus = pneuService.getPneusAleatoire(c);
                unTour.erreurMajeure = false;
                unTour.usurePneus = 0;
                unTour.abandon = false;
                unTour.Course = c;
                unTour.Pilote = unPilote;
                unTour.nb = 0;
                ctx.Add(unTour);
                ctx.SaveChanges();
                res.Add(unTour);
            }
            return res;
        }

        public List<Tour> getDerniersToursByCourse(Course c)
        {
            return ctx.Tour.Where(s => s.Course.idCourse == c.idCourse).OrderByDescending(s => s.tempsTour).ToList();
        }

    }
}
