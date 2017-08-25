using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string IdadeMinima { get; set; }
        public string Horário { get; set; }
        public string Linguagem { get; set; }
        public int Duracao { get; set; }
    }

}