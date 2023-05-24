using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Pneus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int distanceMin { get; set; }
        public int distanceMax { get; set; }
        public float pourcentageFiable { get; set; }
        public virtual Saison Saison { get; set; }
        public string photo { get; set; }
    }
}
