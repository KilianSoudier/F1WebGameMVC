using F1WebGame.Class;
using F1WebGameMVC.Models.PODO;
using F1WebGameMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace F1WebGameMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly CoursesServices coursesServices= new CoursesServices();
        private readonly TourService tourService = new TourService();
        private readonly PiloteServices piloteServices = new PiloteServices();
        private readonly PneuService pneuService = new PneuService();
        public IActionResult Index()
        {
            int idSaison = Convert.ToInt32(Request.Cookies["idSaison"]);
            int idVoiture= Convert.ToInt32(Request.Cookies["idVoiture"]);
            Course? course = coursesServices.getLastCourse(idSaison);
            if(course != null)
            {
                if (coursesServices.checkIfLastCourseIsTerminee(course))
                {
                    Course c = coursesServices.creerNextCourse(idSaison);
                    RedirectToAction("Index");
                }
                else
                {
                    //Tours Classés par temps desc
                    List<Tour> lesDerniersTours = tourService.getDerniersToursByCourse(course);
                    if(lesDerniersTours == null)
                    {
                        List<Tour> lesTours =  tourService.initAutresPilotesCourse(course, idVoiture);
                    }


                    //ViewBag.Tour
                    //ViewBag.voiture = ctx.Voiture.Single(s => s.idVoiture == idVoiture);
                    //    ViewBag.mesPilotes= ctx.Pilote.Where(s=> s.Voiture.idVoiture == idVoiture).OrderBy(s=>s.ordre).ToList();
                    //    ViewBag.course = ctx.Courses.Single(s=>s.Circuit.idCircuit== c.Circuit.idCircuit && s.saison.idSaison== c.saison.idSaison && c.terminee==false);
                    //    ViewBag.circuit = c.Circuit;
                    //    ViewBag.pneus = ctx.Pneus.Where(s=>s.Saison.idSaison==idSaison).ToList();
                    //    ViewBag.pilotes = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).OrderBy(x => Guid.NewGuid()).ToList();
                    return View();
                }
            }
            else
            {
                Course c= coursesServices.creerNextCourse(idSaison);
                RedirectToAction("Index");
            }



            //if (courses.Where(s=>s.terminee==false).Count()==0) //Si aucune course n'est en cours
            //{
            //    Course c = new Course();//Course en cours
            //    if (courses.Count == 0)
            //    {

            //        c.Circuit = ctx.Circuit.First(s => s.saison.idSaison == idSaison);
            //        c.saison = c.Circuit.saison;
            //        c.terminee = false;
            //        c.pilotes = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).ToList();
            //        c.Name = "Grand-Prix de " + c.Circuit.Pays.libelle + "\n" + c.Circuit.nom;
            //    }
            //    else
            //    {
            //        Circuit lastCourse = courses.Last().Circuit;
            //        //Gérer le cas de toutes les courses terminées
            //        Circuit nouvelleCourse = ctx.Circuit.Single(s => s.ordre == lastCourse.ordre + 1);
            //        c.Circuit = nouvelleCourse;
            //        c.saison = c.Circuit.saison;
            //        c.terminee = false;
            //        c.pilotes = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).ToList();
            //        c.Name = "Grand-Prix de " + c.Circuit.Pays.libelle;
            //    }
            //    ctx.Courses.Add(c);
            //    ctx.SaveChanges();
            //    int idVoiture = Convert.ToInt32(Request.Cookies["idVoiture"]);
            //    ViewBag.voiture= ctx.Voiture.Single(s => s.idVoiture == idVoiture);
            //    ViewBag.mesPilotes= ctx.Pilote.Where(s=> s.Voiture.idVoiture == idVoiture).OrderBy(s=>s.ordre).ToList();
            //    ViewBag.course = ctx.Courses.Single(s=>s.Circuit.idCircuit== c.Circuit.idCircuit && s.saison.idSaison== c.saison.idSaison && c.terminee==false);
            //    ViewBag.circuit = c.Circuit;
            //    ViewBag.pneus = ctx.Pneus.Where(s=>s.Saison.idSaison==idSaison).ToList();
            //    ViewBag.pilotes = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).OrderBy(x => Guid.NewGuid()).ToList();
            //}
            //else
            //{
            //    courseEnCours = courses.Where(s => s.terminee == false).SingleOrDefault();
            //    int idVoiture = Convert.ToInt32(Request.Cookies["idVoiture"]);
            //    ViewBag.voiture = ctx.Voiture.Single(s => s.idVoiture == idVoiture);
            //    ViewBag.mesPilotes = ctx.Pilote.Where(s => s.Voiture.idVoiture == idVoiture).OrderBy(s => s.ordre).ToList();
            //    ViewBag.course = courseEnCours;
            //    ViewBag.circuit = courseEnCours.Circuit;
            //    ViewBag.pneus = ctx.Pneus.Where(s => s.Saison.idSaison == idSaison).ToList();
            //    ViewBag.pilotes = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).OrderBy(s=>s.Voiture.ecurie.ordre).ToList();
            //}
            return View();
        }

        //public IActionResult Depart()
        //{
        //    //Context ctx = new Context();
        //    int idVoiture = Convert.ToInt32(Request.Cookies["idVoiture"]);
        //    int idSaison = Convert.ToInt32(Request.Cookies["idSaison"]);

        //    Course c = ctx.Courses.Where(s => s.saison.idSaison == idSaison && s.terminee == false).First();
        //    ViewBag.mesPilotes = ctx.Pilote.Where(s => s.Voiture.idVoiture == idVoiture).OrderBy(s => s.ordre).ToList();
        //    ViewBag.course = c;
        //    ViewBag.tours= ctx.Tour.Where(s=>s.Course.idCourse==c.idCourse).OrderBy(x => Guid.NewGuid()).ToList();


        //    return View();
        //}

        //public IActionResult TourSuivant()
        //{
        //    int idVoiture = Convert.ToInt32(Request.Cookies["idVoiture"]);
        //    int idSaison = Convert.ToInt32(Request.Cookies["idSaison"]);
        //    Course c = new Course();//Course en cours
        //    ViewBag.voiture = ctx.Voiture.Single(s => s.idVoiture == idVoiture);
        //    ViewBag.mesPilotes = ctx.Pilote.Where(s => s.Voiture.idVoiture == idVoiture).OrderBy(s => s.ordre).ToList();
        //    ViewBag.course = ctx.Courses.Single(s => s.Circuit.idCircuit == c.Circuit.idCircuit && s.saison.idSaison == c.saison.idSaison && c.terminee == false);
        //    ViewBag.circuit = c.Circuit;
        //    ViewBag.pneus = ctx.Pneus.Where(s => s.Saison.idSaison == idSaison).ToList();
        //    ViewBag.pilotes = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).OrderBy(x => Guid.NewGuid()).ToList();

        //    return View();
        //}



        [HttpPost]
        public bool choixPneusJoueur(int idPneu, int idPilote,int idCourse)
        {
            Course laCourse = coursesServices.getCourseById(idCourse);
            Pilote pilote = piloteServices.getPiloteById(idPilote);
            Pneus pneu = pneuService.getPneuById(idPneu);
            Tour tourJoueur = tourService.initCourseUnPilote(laCourse, pilote, pneu);
            return tourService.verifTousPilotesPneusChoisis(laCourse);
        }

        //[HttpPost]
        //public bool verifPneusChoisis(int idCourse)
        //{
        //    int idVoiture= Convert.ToInt32(Request.Cookies["idVoiture"]);
        //    List<int> lesIdPilotes = ctx.Pilote.Where(s => s.Voiture.idVoiture == idVoiture).Select(s=>s.idPilote).ToList();
        //    List<Tour> lesTours = ctx.Tour.Where(s => lesIdPilotes.Contains(s.Pilote.idPilote)).ToList();
        //    if (lesTours.Count == lesIdPilotes.Count)
        //        return true;
        //    else
        //        return false;
        //}

        //public bool verifTousPilotesPneusChoisis(Pilote Pilote)
        //{
        //    List<int> idp = ctx.Pilote.Where(s => s.Voiture.idVoiture == Pilote.Voiture.idVoiture).Select(s=>s.idPilote).ToList();
        //    List<Pilote> pilotesChoisis = ctx.Tour.Where(s => idp.Contains(s.Pilote.idPilote)).Select(s=>s.Pilote).ToList();
        //    if (pilotesChoisis.Count == idp.Count)
        //        return true;
        //    else
        //        return false;
        //}

        //public void initAutreJoueurs(Course course, Pilote Pilote)
        //{
        //    List<int> idp = ctx.Pilote.Where(s => s.Voiture.idVoiture == Pilote.Voiture.idVoiture).Select(s => s.idPilote).ToList();
        //    List<Pilote> lesConcurrents = ctx.Pilote.Where(s=>!idp.Contains(s.idPilote) && s.Voiture.saison.idSaison== Pilote.Voiture.saison.idSaison).ToList();
        //    List<Tour> tours = new List<Tour>();
        //    foreach(Pilote p in lesConcurrents)
        //    {
        //        Tour tourConcurrent = new Tour();
        //        tourConcurrent.nb = 0;
        //        tourConcurrent.usurePneus = 0;
        //        tourConcurrent.abandon = false;
        //        tourConcurrent.pneus = ctx.Pneus.Where(s => s.Saison.idSaison==Pilote.Voiture.saison.idSaison).OrderBy(x => Guid.NewGuid()).First();
        //        tourConcurrent.erreurMajeure = false;
        //        tourConcurrent.Course = ctx.Courses.Single(s => s.idCourse == course.idCourse);
        //        tourConcurrent.Pilote = ctx.Pilote.Single(s => s.idPilote == p.idPilote);

        //        tours.Add(tourConcurrent);
        //        ctx.Tour.Add(tourConcurrent);
        //        ctx.SaveChanges();
        //    }

        //    ViewBag.lesTours = tours;
        //}

        //public void depart()
        //{
        //    Random rnd= new Random();
        //    int abandon = rnd.Next(0, 100);
        //    rnd= new Random();
        //    int degats = rnd.Next(0, 100);

        //}
    }
}
