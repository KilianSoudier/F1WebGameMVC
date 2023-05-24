using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;

namespace F1WebGameMVC.Services
{
    public class CoursesServices
    {
        private readonly Context ctx = new Context();
        private readonly VoitureServices voitureServices = new VoitureServices();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly ClassementServices classementServices = new ClassementServices();
        private readonly CircuitServices circuitServices = new CircuitServices();
        private readonly SaisonServices saisonServices = new SaisonServices();

        public Course? getLastCourse(int idSaison)
        {
            return ctx.Courses.Where(s => s.saison.idSaison == idSaison).LastOrDefault();
        }

        public Course creerNextCourse (int idSaison)
        {
            List<Course> lesCoursesCreees= getAllCoursesBySaison(idSaison);
            Circuit lastCircuitCourse = lesCoursesCreees.OrderByDescending(s=>s.Circuit.ordre).Select(s=>s.Circuit).First();

            List<Circuit> lesCircuits = circuitServices.getAllCircuits(idSaison);
            Course c = new Course();
            c.pilotes = piloteServices.getPilotesBySaison(idSaison);
            c.terminee = false;
            c.Circuit = circuitServices.getCircuitByOrdre(idSaison, lastCircuitCourse.ordre+1);
            c.saison = saisonServices.getSaisonById(idSaison);
            c.Name = "Grand Prix de " + c.Circuit.Pays.libelle;

            ctx.Add(c);
            ctx.SaveChanges();
            return c;
        }
        public List<Course> getAllCoursesBySaison(int idSaison)
        {
            return ctx.Courses.Where(s => s.saison.idSaison == idSaison ).OrderBy(s => s.Circuit.ordre).ToList();
        }

        public bool checkIfLastCourseIsTerminee(Course c)
        {
            return c.terminee;
        }

        public Course getCourseById(int id)
        {
            return ctx.Courses.Single(s => s.idCourse == id);
        }
    }
}
