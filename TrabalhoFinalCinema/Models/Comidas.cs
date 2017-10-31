using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Comidas
    {
        public int Id { get; set; }
        [Required]
        [Display (Name = "Tipo")]
        public string Tipo { get; set; }
        [Required]
        [Display (Name = "Preço")]
        public double Preco { get; set; }

    }
}