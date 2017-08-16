using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoFinalCinema.Models
{
    public class Empregados
    {
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public int Idade { get; set; }
        public string Aniversario { get; set; }
        public string CPF { get; set; }
    }
}