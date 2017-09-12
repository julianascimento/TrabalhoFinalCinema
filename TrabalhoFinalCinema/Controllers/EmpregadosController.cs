using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;
using TrabalhoFinalCinema.ViewModels;

namespace TrabalhoFinalCinema.Controllers
{
    public class EmpregadosController : Controller
    {
        private ApplicationDbContext _context;

        public EmpregadosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var empregados = _context.Empregados.ToList();

            return View(empregados);
        }

        public ActionResult Details(int id)
        {
            var empregado = _context.Empregados.SingleOrDefault(e => e.Id == id);
            if (empregado == null)
            {
                return HttpNotFound();
            }

            return View(empregado);
        }
    }
}