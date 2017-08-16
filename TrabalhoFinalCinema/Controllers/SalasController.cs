using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.Controllers
{
    public class SalasController : Controller
    {
        // GET: Salas
        public ActionResult Salas()
        {
            var sala = new Salas()
            {
                Id = "A"
            };
            return View();
        }
    }
}