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
    
    public ActionResult New()
    {
        var viewModel = new SalasIndexViewModel{};

        return View("SalasForm", viewModel);
    }

    [HttpPost] // só será acessada com POST
    public ActionResult Save(Salas sala) // recebemos um cliente
    {

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

    public ActionResult Edit(int id)
    {
        var sala = _context.Salas.SingleOrDefault(c => c.Id == id);

        if (sala == null)
            return HttpNotFound();

        return View("SalaForm", sala);
    }
}
}