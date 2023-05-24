using F1WebGame.Class;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace F1WebGameMVC.Models.PODO
{
    public class Saison
    {
        [Key]
        public int idSaison { get; set; }
        [Required]
        public string libelleSaison { get; set; }

    }
}
