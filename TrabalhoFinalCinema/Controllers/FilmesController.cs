using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.Controllers
{
    public class FilmesController : Controller
    {
        // GET: Filmes
        public ActionResult Filmes()
        {
            var filme = new Filmes()
            {
                Id = 123,
                Nome = "Mulher Maravilha"
            };
            return View(filme);
        }
    }
}