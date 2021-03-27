using InvoiceManagerApp.Data;
using InvoiceManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly Contexto _contexto;

        public FornecedorController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            IEnumerable<Fornecedor> objList = _contexto.Fornecedor;
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
        public IActionResult Create(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _contexto.Fornecedor.Add(fornecedor);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Fornecedor.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _contexto.Fornecedor.Update(fornecedor);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Fornecedor.Find(id);
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
            var obj = _contexto.Fornecedor.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _contexto.Fornecedor.Remove(obj);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
