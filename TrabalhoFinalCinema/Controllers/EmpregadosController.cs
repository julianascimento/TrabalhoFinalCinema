using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;

namespace TrabalhoFinalCinema.Controllers
{
    public class EmpregadosController : Controller
    {
        // GET: Empregados
        public ActionResult Empregados()
        {
            var empregado = new Empregados()
            {
                Nome = "Paulo",
                Idade = 22,
                Aniversario = "24/02/1996",
                CPF = "123.456.789-00",
                Funcao = "Vendedor de ingressos",
                Salario = 500.00
            };
            return View(empregado);
        }
    }
}