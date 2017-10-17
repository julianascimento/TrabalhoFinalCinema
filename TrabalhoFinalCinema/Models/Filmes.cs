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
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        [Display(Name = "Idade Mínima")]
        public string IdadeMinima { get; set; }
        [Display(Name = "Horário")]
        public string Horario { get; set; }
        [Display(Name = "Linguagem")]
        public string Linguagem { get; set; }
        [Display(Name = "Duração")]
        public int Duracao { get; set; }
    }

}