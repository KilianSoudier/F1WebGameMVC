using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Tour
    {
        [Key]
        public int Id { get; set; }
        public int nb { get; set; }
        public virtual Pilote Pilote { get; set; }
        public virtual Course Course { get; set; }
        public TimeSpan tempsTour { get; set; }
        public bool abandon { get; set; }
        public bool erreurMajeure { get; set; }
        public virtual Pneus pneus { get; set; }
        public float usurePneus { get; set; }
    }
}
