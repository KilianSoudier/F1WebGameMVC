using F1WebGame.Class;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Classements
    {
        [Key]
        public int ClassementId { get; set; }
        public virtual Pilote pilote { get; set; }
        public int pointsPilotes { get; set; }
        public virtual Ecurie ecurie { get; set; }
        public int pointsConstructeur { get; set; }
        public virtual Circuit Circuit { get; set; }

        public void initialiserSaison(int idSaison)
        {
            Context ctx = new Context();
            Circuit c = ctx.Circuit.Single(s => s.saison.idSaison == idSaison && s.ordre == 1);
            List<Pilote> p = ctx.Pilote.Where(s => s.Voiture.saison.idSaison == idSaison).ToList();

            foreach (var unP in p)
            {
                Classements unClassement = new Classements();
                unClassement.pilote = unP;
                unClassement.pointsPilotes = 0;
                unClassement.ecurie = unP.Voiture.ecurie;
                unClassement.pointsConstructeur = 0;
                unClassement.Circuit = c;
                ctx.Classement.Add(unClassement);
                ctx.SaveChanges();
            }
        }

    }
}
