using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.ViewModels
{
    public class EmpregadoIndexViewModel
    {
        //public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Empregados Empregado { get; set; }
        public string Title
        {
            get
            {
                if (Empregado != null && Empregado.Id != 0)
                {
                    return "Editar Empregado";
                }

                return "Novo Empregado";
            }
        }
        //public List <Empregados> Empregado { get; set; }
    }
}