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

        public List<Salas> salas = new List<Salas>
        {
            new Salas {Nome = "A", Id = 1, CapacidadePessoas = 150, TresD = "Não"},
            new Salas {Nome = "B", Id = 2, CapacidadePessoas = 300, TresD = "Sim"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new SalasIndexViewModel
            {
                Salas = salas
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (salas.Count < id)
            {
                return HttpNotFound();
            }

            var s = salas[id - 1];

            return View(s);

            // GET: Salas
            /*public ActionResult Salas()
            {
                var sala = new Salas()
                {
                    Id = "A1",
                    TresD = "Sim",
                    CapacidadePessoas = 100

                };
                return View(sala);
            }*/
        }
    }
}