using InvoiceManagerApp.Data;
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
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();            
            IEnumerable<Fatura> objList = _contexto.Fatura;
            return View(objList);
        }

        // GET - CREATE
        public IActionResult Create()
        {
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();            
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fatura fatura)
        {
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();

            if (ModelState.IsValid)
            {
                _contexto.Fatura.Add(fatura);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fatura);
        }

        // GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Fatura.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fatura fatura)
        {
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();

            if (ModelState.IsValid)
            {
                _contexto.Fatura.Update(fatura);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fatura);
        }

        // GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();

            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Fatura.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            ViewBag.Fornecedores = _contexto.Fornecedor.ToList();
            ViewBag.Clientes = _contexto.Cliente.ToList();

            var obj = _contexto.Fatura.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _contexto.Fatura.Remove(obj);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
