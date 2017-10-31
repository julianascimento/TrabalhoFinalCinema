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
        private ApplicationDbContext _context;
        public FilmesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var filmes = _context.Filmes.ToList();
            return View(filmes);
        }

        public ActionResult Details(int id)
        {
            var filme = _context.Filmes.SingleOrDefault(f => f.Id == id);
            if (filme == null)
            {
                return HttpNotFound();
            }

            return View(filme);
        }
    
    public ActionResult New()
    {
        var viewModel = new FilmesIndexViewModel{ };

        return View("FilmeForm", viewModel);
    }

    [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Filmes filme) // recebemos um cliente
    {
            if (!ModelState.IsValid)
            {
                var viewModel = new FilmesIndexViewModel{ };

                return View("FilmeForm", viewModel);
            }

            if (filme.Id == 0)
        {
            // armazena o cliente em memória
            _context.Filmes.Add(filme);
        }
        else
        {
            var filmeNoBD = _context.Filmes.Single(c => c.Id == filme.Id);

            filmeNoBD.Nome = filme.Nome;
            filmeNoBD.Genero = filme.Genero;
            filmeNoBD.IdadeMinima = filme.IdadeMinima;
            filmeNoBD.Horario = filme.Horario;
            filmeNoBD.Linguagem = filme.Linguagem;
            filmeNoBD.Duracao = filme.Duracao;
        }

        // faz a persistência
        _context.SaveChanges();
        // Voltamos para a lista de clientes
        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var filme = _context.Filmes.SingleOrDefault(f => f.Id == id);

        if (filme == null)
            return HttpNotFound();

        return View("FilmeForm", filme);
    }
}
}