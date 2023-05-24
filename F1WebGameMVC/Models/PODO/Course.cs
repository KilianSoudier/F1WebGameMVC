using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Course
    {
        [Key]
        public int idCourse { get; set; }
        public virtual Saison saison { get; set; }
        public string Name { get; set; }
        public virtual Circuit Circuit { get; set; }
        public virtual List<Pilote> pilotes { get; set; }
        public virtual List<Tour> tours { get; set; }
        public bool terminee { get; set; }

    }
}
