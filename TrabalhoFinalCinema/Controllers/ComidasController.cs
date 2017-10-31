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
    
    public ActionResult New()
    {
        var viewModel = new ComidasIndexViewModel{ };

        return View("ComidaForm", viewModel);
    }

    [HttpPost] // só será acessada com POST
    public ActionResult Save(Comidas comida) // recebemos um cliente
    {
            if (!ModelState.IsValid)
            {
                var viewModel = new ComidasIndexViewModel{ };

                return View("ComidaForm", viewModel);
            }

            if (comida.Id == 0)
        {
            // armazena o cliente em memória
            _context.Comidas.Add(comida);
        }
        else
        {
            var comidaNoBD = _context.Comidas.Single(c => c.Id == comida.Id);

                comidaNoBD.Tipo = comida.Tipo;
                comidaNoBD.Preco = comida.Preco;
        }

        // faz a persistência
        _context.SaveChanges();
        // Voltamos para a lista de clientes
        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var comida = _context.Comidas.SingleOrDefault(c => c.Id == id);

        if (comida == null)
            return HttpNotFound();


        return View("ComidaForm", comida);
    }
}
}