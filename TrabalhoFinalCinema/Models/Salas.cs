using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Salas
    {
        [Required]
        [Display (Name = "Nome")]
        public string Nome { get; set; }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Capacidade de Pessoas")]
        public int? CapacidadePessoas { get; set; }
        [Required]
        [Display(Name = "3D")]
        public bool TresD { get; set;}
    }
}