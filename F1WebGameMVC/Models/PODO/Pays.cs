using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Pays
    {
        [Key]
        public int idPays { get; set; }
        public string libelle { get; set; }
        public string photoDrapeau { get; set; }
    }
}
