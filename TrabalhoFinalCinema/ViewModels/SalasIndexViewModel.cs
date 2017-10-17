using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.ViewModels
{
    public class SalasIndexViewModel
    {
        public Salas Sala { get; set; }
        public string Title
        {
            get
            {
                if(Sala !=null && Sala.Id != 0)
                {
                    return "Editar Sala";
                }
                return "Nova Sala";
            }
        }
    }
}