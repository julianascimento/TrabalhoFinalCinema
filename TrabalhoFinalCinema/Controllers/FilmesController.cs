using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;
using TrabalhoFinalCinema.ViewModels;

namespace TrabalhoFinalCinema.Controllers
{
    public class FilmesController : Controller
    {

        public List<Filmes> filmes = new List<Filmes>
        {
            new Filmes {Nome = "Mulher Maravilha", Id = 1, Genero = "Aventura, Ficção", IdadeMinima = "Livre", Duracao = 150, Horário = "15h, 18, 20h", Linguagem = "Legendado"},
            new Filmes {Nome = "Capitão América", Id = 2, Genero = "Aventura, Ficção", IdadeMinima = "Livre", Duracao = 168, Horário = "13h30, 16h, 21h", Linguagem = "Legendado"}
        };

        public ActionResult Index()
        {
            var viewModel = new FilmesIndexViewModel
            {
                Filmes = filmes
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (filmes.Count < id)
            {
                return HttpNotFound();
            }

            var f = filmes[id - 1];

            return View(f);

            /*// GET: Filmes
            public ActionResult Filmes()
            {
                var filme = new Filmes()
                {
                    Id = 123,
                    Nome = "Mulher Maravilha"
                };
                return View(filme);
            }*/
        }
    }
}