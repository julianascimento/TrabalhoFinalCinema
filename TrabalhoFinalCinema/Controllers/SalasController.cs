using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;
using TrabalhoFinalCinema.ViewModels;

namespace TrabalhoFinalCinema.Controllers
{
    public class SalasController : Controller
    {
        private ApplicationDbContext _context;

        public SalasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var salas = _context.Salas.ToList();

            return View(salas);
        }

        public ActionResult Details(int id)
        {
            var sala = _context.Salas.SingleOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return HttpNotFound();
            }

            return View(sala);
        }
    }
}