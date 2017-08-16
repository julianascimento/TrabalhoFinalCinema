using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.Controllers
{
    public class ComidasController : Controller
    {
        // GET: Comidas
        public ActionResult Comidas()
        {
            var comida = new Comidas()
            {
                Tipo = "pipoca",
                Preco = 5.00
            };
            return View();
        }
    }
}