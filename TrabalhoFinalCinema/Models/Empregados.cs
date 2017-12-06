using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Empregados
    {
        public int Id { get; set; }
        [Required]
        [Display (Name = "Nome")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Função")]
        public string Funcao { get; set; }
        [Required]
        [Display(Name = "Salário")]
        public double? Salario { get; set; }
        [Display(Name = "Idade")]
        [Min16Years]
        public int? Idade { get; set; }
        [Required]
        [Display(Name = "Aniversário")]
        public string Aniversario { get; set; }
        [Required]
        public string CPF { get; set; }
    }
}