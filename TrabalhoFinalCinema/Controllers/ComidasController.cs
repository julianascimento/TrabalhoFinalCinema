using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;
using TrabalhoFinalCinema.ViewModels;

namespace TrabalhoFinalCinema.Controllers
{
    public class ComidasController : Controller
    {
        private ApplicationDbContext _context;

        public ComidasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose (bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
                var comidas = _context.Comidas.ToList();

            return View(comidas);
        }

        public ActionResult Details(int id)
        {
            var comida = _context.Comidas.SingleOrDefault(c => c.Id == id);
            if (comida == null)
            {
                return HttpNotFound();
            }
            return View(comida);
        }
    }
}