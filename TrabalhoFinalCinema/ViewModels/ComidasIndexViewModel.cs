using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.ViewModels
{
    public class ComidasIndexViewModel
    {
        public Comidas Comida { get; set; }
        public string Title
        {
            get
            {
                if(Comida != null && Comida.Id != 0)
                {
                    return "Editar Comida";
                }
                return "Nova Comida";
            }
        }
    }
}