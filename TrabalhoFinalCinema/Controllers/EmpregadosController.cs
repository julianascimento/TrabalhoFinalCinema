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
        [Authorize]
        public ActionResult Index()
        {
            var empregados = _context.Empregados.ToList();
            if (User.IsInRole("CanManage"))
                return View(empregados);
            return View("ReadOnlyIndex", empregados);
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

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult New()
        {
            var empregado = new Empregados { };

            return View("EmpregadoForm", empregado);
        }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Save(Empregados empregado) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                
                return View("EmpregadoForm", empregado);
            }

            if (empregado.Id == 0)
            {
                // armazena o cliente em memória
                _context.Empregados.Add(empregado);
            }
            else
            {
                var empregadoNoBD = _context.Empregados.Single(c => c.Id == empregado.Id);

                empregadoNoBD.Nome = empregado.Nome;
                empregadoNoBD.Idade = empregado.Idade;
                empregadoNoBD.Aniversario = empregado.Aniversario;
                empregadoNoBD.Funcao = empregado.Funcao;
                empregadoNoBD.Salario = empregado.Salario;
                empregadoNoBD.CPF = empregado.CPF;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit(int id)
        {
            var empregado = _context.Empregados.SingleOrDefault(c => c.Id == id);

            if (empregado == null)
                return HttpNotFound();

            return View("EmpregadoForm", empregado);
        }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Delete(int id)
        {
            var empregados = _context.Empregados.SingleOrDefault(c => c.Id == id);

            if (empregados == null)
                return HttpNotFound();

            _context.Empregados.Remove(empregados);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

    }
}