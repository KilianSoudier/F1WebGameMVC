using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Pilote
    {
        [Key]
        public int idPilote { get; set; }
        public string nom { get; set; }
        public virtual Voiture Voiture { get; set; }
        public int vitessePointe { get; set; }
        public int vitesseVirage { get; set; }
        public int economiePneus { get; set; }
        public int economieEssence { get; set; }
        public string photo { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual List<Course> Courses { get; set; }
        public int ordre { get; set; }

        public string getPourcent(int value)
        {
            switch (value)
            {
                case 0:
                    return "0%";
                case 1:
                    return "20%";
                case 2:
                    return "40%";
                case 3:
                    return "60%";
                case 4:
                    return "80%";
                case 5:
                    return "100%";
                default:
                    throw new Exception("erreur");
            }
        }
    }
}
