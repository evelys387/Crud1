using Crud1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud1.Controllers
{
    public class NiniosController : Controller
    {
        private readonly ADBcontext _context;

        public NiniosController(ADBcontext context)
        {
            _context = context;
        }
        
        //get index
        public IActionResult Index()
        {
            IEnumerable<Ninio> listNinios = _context.Ninio;
            return View(listNinios);
        }

        //get create
        public IActionResult Create()
        {
            return View();
        }

        //post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ninio ninio)
        {
            if(ModelState.IsValid)
            {
                _context.Ninio.Add(ninio);
                _context.SaveChanges();

                TempData["mensaje"] = "El niño se ha ingresado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //get edit
        public IActionResult Edit(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }

            var ninio = _context.Ninio.Find(id);

            if (ninio==null)
            {
                return NotFound();
            }

            return View(ninio);
        }
        //post editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Ninio ninio)
        {
            if (ModelState.IsValid)
            {
                _context.Ninio.Update(ninio);
                _context.SaveChanges();

                TempData["mensaje"] = "El niño se ha actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //get delete, asegurar que tenga el mismo nombre la vista
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var ninio = _context.Ninio.Find(id);

            if (ninio == null)
            {
                return NotFound();
            }

            return View(ninio);
        }
        //post eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteN(int? id)
        {
            var ninio = _context.Ninio.Find(id);

            if (ninio == null)
            {
                return NotFound();
            } 
            
            _context.Ninio.Remove(ninio);
            _context.SaveChanges();
            
            TempData["mensaje"] = "El registro del niño se ha eliminado correctamente";
            return RedirectToAction("Index");
        }
    }
}
