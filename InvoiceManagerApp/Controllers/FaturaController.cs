﻿using InvoiceManagerApp.Data;
using InvoiceManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Controllers
{
    public class FaturaController : Controller
    {
        private readonly Contexto _contexto;

        public FaturaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            IEnumerable<Fatura> objList = _contexto.Fatura;
            return View(objList);
        }

        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fatura Fatura)
        {
            _contexto.Fatura.Add(Fatura);
            _contexto.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}