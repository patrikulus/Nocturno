using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class SimpleTextController : Controller
    {
        private NocturnoContext _context;

        public SimpleTextController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: SimpleText
        public IActionResult Index()
        {
            return View(_context.SimpleTexts.ToList());
        }

        // GET: SimpleText/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SimpleText simpleText = _context.SimpleTexts.Single(m => m.Id == id);
            if (simpleText == null)
            {
                return HttpNotFound();
            }

            return View(simpleText);
        }

        // GET: SimpleText/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SimpleText/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SimpleText simpleText)
        {
            if (ModelState.IsValid)
            {
                _context.SimpleTexts.Add(simpleText);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(simpleText);
        }

        // GET: SimpleText/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SimpleText simpleText = _context.SimpleTexts.Single(m => m.Id == id);
            if (simpleText == null)
            {
                return HttpNotFound();
            }
            return View(simpleText);
        }

        // POST: SimpleText/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SimpleText simpleText)
        {
            if (ModelState.IsValid)
            {
                _context.Update(simpleText);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(simpleText);
        }

        // GET: SimpleText/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SimpleText simpleText = _context.SimpleTexts.Single(m => m.Id == id);
            if (simpleText == null)
            {
                return HttpNotFound();
            }

            return View(simpleText);
        }

        // POST: SimpleText/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            SimpleText simpleText = _context.SimpleTexts.Single(m => m.Id == id);
            _context.SimpleTexts.Remove(simpleText);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}