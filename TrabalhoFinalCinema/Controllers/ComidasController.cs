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

        public List<Comidas> comidas = new List<Comidas>
        {
            new Comidas {Tipo = "Pipoca", Id = 1, Preco = 8},
            new Comidas {Tipo = "Chips", Id = 2, Preco = 4}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new ComidasIndexViewModel
            {
                Comidas = comidas
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (comidas.Count < id)
            {
                return HttpNotFound();
            }

            var c = comidas[id - 1];

            return View(c);

            // GET: Comidas
            /*public ActionResult Comidas()
            {
                var comida = new Comidas()
                {
                    Tipo = "Pipoca",
                    Preco = 5.00
                };
                return View(comida);
            }*/
        }
    }
}