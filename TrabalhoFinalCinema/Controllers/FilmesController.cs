﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinalCinema.Models;
using TrabalhoFinalCinema.ViewModels;

namespace TrabalhoFinalCinema.Controllers
{
    [Authorize]
    public class FilmesController : Controller
    {
        private ApplicationDbContext _context;
        public FilmesController()
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
            var filmes = _context.Filmes.ToList();
            if (User.IsInRole("CanManage"))
                return View(filmes);
            return View("ReadOnlyIndex", filmes);
        }

        public ActionResult Details(int id)
        {
            var filme = _context.Filmes.SingleOrDefault(f => f.Id == id);
            if (filme == null)
            {
                return HttpNotFound();
            }

            return View(filme);
        }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult New()
    {
        var filme = new Filmes{ };

        return View("FilmeForm", filme);
    }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Save(Filmes filme) // recebemos um cliente
    {
            if (!ModelState.IsValid)
            {
                var viewModel = new FilmesIndexViewModel{ };

                return View("FilmeForm", viewModel);
            }

            if (filme.Id == 0)
        {
            // armazena o cliente em memória
            _context.Filmes.Add(filme);
        }
        else
        {
            var filmeNoBD = _context.Filmes.Single(c => c.Id == filme.Id);

            filmeNoBD.Nome = filme.Nome;
            filmeNoBD.Genero = filme.Genero;
            filmeNoBD.IdadeMinima = filme.IdadeMinima;
            filmeNoBD.Horario = filme.Horario;
            filmeNoBD.Linguagem = filme.Linguagem;
            filmeNoBD.Duracao = filme.Duracao;
        }

        // faz a persistência
        _context.SaveChanges();
        // Voltamos para a lista de clientes
        return RedirectToAction("Index");
    }

        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit(int id)
    {
        var filme = _context.Filmes.SingleOrDefault(f => f.Id == id);

        if (filme == null)
            return HttpNotFound();

        return View("FilmeForm", filme);
    }


        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Delete(int id)
        {
            var filmes = _context.Filmes.SingleOrDefault(c => c.Id == id);

            if (filmes == null)
                return HttpNotFound();

            _context.Filmes.Remove(filmes);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}