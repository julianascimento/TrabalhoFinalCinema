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
    }
}