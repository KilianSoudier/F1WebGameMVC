using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using F1WebGame.Class;

namespace F1WebGameMVC.Models.PODO
{
    public class Voiture
    {
        [Key]
        public int idVoiture { get; set; }
        public string nomVoiture { get; set; }
        public virtual Ecurie ecurie { get; set; }
        public int vitessePointe { get; set; }
        public int maniabilite { get; set; }
        public int economieEssence { get; set; }
        public int economiePneus { get; set; }
        public string photo { get; set; }
        public virtual Saison saison { get; set; }
        //[NotMapped]
        public virtual List<Pilote> pilotes { get; set; }


        

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
