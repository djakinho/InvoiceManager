using InvoiceManagerApp.Data;
using InvoiceManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Contexto _contexto;

        public ClienteController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> objList = _contexto.Cliente;
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
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Cliente.Add(cliente);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Cliente.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Cliente.Update(cliente);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Cliente.Find(id);
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
            var obj = _contexto.Cliente.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _contexto.Cliente.Remove(obj);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
