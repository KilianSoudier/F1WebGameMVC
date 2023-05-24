using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Ecurie
    {
        [Key]
        public int idEcurie { get; set; }
        public string nomEcurie { get; set; }
        public string photo { get; set; }
        public int ordre { get; set; }
        public virtual Pays Pays { get; set; }
        public string colorSite { get; set; }
        public string colorEcriture { get; set; }
    }
}
