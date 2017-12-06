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
        [Authorize]
        public ActionResult Index()
        {
            var salas = _context.Salas.ToList();
            if (User.IsInRole("CanManage"))
                return View(salas);
            return View("ReadOnlyIndex", salas);
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

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult New()
        {
            var sala = new Salas();

            return View("SalaForm", sala);
        }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Save(Salas sala) // recebemos um cliente
    {
            if (!ModelState.IsValid)
            {
                var viewModel = new SalasIndexViewModel { };
                return View("SalaForm", sala);
            }

            if (sala.Id == 0)
        {
            // armazena o cliente em memória
            _context.Salas.Add(sala);
        }
        else
        {
            var salaNoBD = _context.Salas.Single(c => c.Id == sala.Id);

            salaNoBD.Nome = sala.Nome;
            salaNoBD.CapacidadePessoas = sala.CapacidadePessoas;
            salaNoBD.TresD = sala.TresD;
        }

        // faz a persistência
        _context.SaveChanges();
        // Voltamos para a lista de clientes
        return RedirectToAction("Index");
    }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit(int id)
        {
            var sala = _context.Salas.SingleOrDefault(c => c.Id == id);

            if (sala == null)
                return HttpNotFound();

            return View("SalaForm", sala);
        }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Delete(int id)
        {
            var salas = _context.Salas.SingleOrDefault(c => c.Id == id);

            if (salas == null)
                return HttpNotFound();

            _context.Salas.Remove(salas);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}