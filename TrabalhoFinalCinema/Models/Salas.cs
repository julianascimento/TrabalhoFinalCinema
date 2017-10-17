using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Salas
    {
        [Display (Name = "Nome")]
        public string Nome { get; set; }
        public int Id { get; set; }
        [Display(Name = "Capacidade de Pessoas")]
        public int CapacidadePessoas { get; set; }
        [Display(Name = "3D")]
        public string TresD { get; set;}
    }
}