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
    [Authorize]
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
        [Authorize]
        public ActionResult Index()
        {
            var comidas = _context.Comidas.ToList();
            if (User.IsInRole("CanManage"))
                return View(comidas);
            return View("ReadOnlyIndex", comidas);
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

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult New()
    {
        var comida = new Comidas();

        return View("ComidaForm", comida);
    }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Save(Comidas comida) // recebemos um cliente
    {
            if (!ModelState.IsValid)
            {
                return View("ComidaForm", comida);
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

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit(int id)
    {
        var comida = _context.Comidas.SingleOrDefault(c => c.Id == id);

        if (comida == null)
            return HttpNotFound();


        return View("ComidaForm", comida);
    }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Delete(int id)
        {
            var comidas = _context.Comidas.SingleOrDefault(c => c.Id == id);

            if (comidas == null)
                return HttpNotFound();

            _context.Comidas.Remove(comidas);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}