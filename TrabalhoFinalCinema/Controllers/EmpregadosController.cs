using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;
using TrabalhoFinalCinema.ViewModels;

namespace TrabalhoFinalCinema.Controllers
{
    public class EmpregadosController : Controller
    {
        public List<Empregados> empregados = new List<Empregados>
        {
            new Empregados {Nome = "John Smith", Id = 1, Funcao = "Vendedor", Idade = 22, Aniversario = "24/02/1996",
            CPF = "123.456.789-00", Salario = 800.00},
            new Empregados {Nome = "Mary Williams", Id = 2, Funcao = "Segurança", Idade = 20, Aniversario = "02/06/1997",
            CPF = "987.654.321-00", Salario = 850.00}
        };

        public ActionResult Index()
        {
            var viewModel = new EmpregadoIndexViewModel
            {
                Empregado = empregados
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (empregados.Count < id)
            {
                return HttpNotFound();
            }

            var e = empregados[id - 1];

            return View(e);
        }
    }
}