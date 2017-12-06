using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Idade Mínima")]
        public string IdadeMinima { get; set; }
        [Required]
        [Display(Name = "Horário")]
        public string Horario { get; set; }
        [Required]
        [Display(Name = "Linguagem")]
        public string Linguagem { get; set; }
        [Required]
        [Display(Name = "Duração")]
        public int? Duracao { get; set; }
    }

}