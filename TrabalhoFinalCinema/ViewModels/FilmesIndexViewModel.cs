using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.ViewModels
{
    public class FilmesIndexViewModel
    {
        public Filmes Filme { get; set; }
        public string Title
        {
            get
            {
                if (Filme != null && Filme.Id != 0)
                {
                    return "Editar Filme";
                }
                return "Novo Filme";
            }
        }
    }
}