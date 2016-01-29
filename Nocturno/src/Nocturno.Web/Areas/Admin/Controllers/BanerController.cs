using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class BanerController : Controller
    {
        private NocturnoContext _context;

        public BanerController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Baner
        public IActionResult Index()
        {
            return View(_context.Baners.ToList());
        }

        // GET: Baner/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Baner baner = _context.Baners.Single(m => m.Id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }

            return View(baner);
        }

        // GET: Baner/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Baner/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Baner baner)
        {
            if (ModelState.IsValid)
            {
                _context.Baners.Add(baner);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baner);
        }

        // GET: Baner/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Baner baner = _context.Baners.Single(m => m.Id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }
            return View(baner);
        }

        // POST: Baner/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Baner baner)
        {
            if (ModelState.IsValid)
            {
                _context.Update(baner);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baner);
        }

        // GET: Baner/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Baner baner = _context.Baners.Single(m => m.Id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }

            return View(baner);
        }

        // POST: Baner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Baner baner = _context.Baners.Single(m => m.Id == id);
            _context.Baners.Remove(baner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}