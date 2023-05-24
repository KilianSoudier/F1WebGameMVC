using F1WebGame.Class;
using Microsoft.AspNetCore.Components.Server.Circuits;
using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Circuit
    {
        [Key]
        public int idCircuit { get; set; }
        public string nom { get; set; }
        public virtual Saison saison { get; set; }
        public int usurePneus { get; set; }
        public int usureEssence { get; set; }
        public int ligneDroite { get; set; }
        public int virages { get; set; }
        public string photo { get; set; }
        public TimeSpan tempsMoyen { get; set; }
        public DateTime premierGP { get; set; }
        public int nbTours { get; set; }
        public float distanceTour { get; set; }
        public TimeSpan recordTour { get; set; }
        public virtual Pays Pays { get; set; }
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
