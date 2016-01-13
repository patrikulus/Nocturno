using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class SectionController : Controller
    {
        private NocturnoContext _context;

        public SectionController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Section
        public IActionResult Index()
        {
            return View(_context.Sections.ToList());
        }

        // GET: Section/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Sections.Single(m => m.Id == id);
            if (section == null)
            {
                return HttpNotFound();
            }

            return View(section);
        }

        // GET: Section/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Section/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Sections.Add(section);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(section);
        }

        // GET: Section/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Sections.Single(m => m.Id == id);
            if (section == null)
            {
                return HttpNotFound();
            }
            return View(section);
        }

        // POST: Section/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Section section)
        {
            if (ModelState.IsValid)
            {
                _context.Update(section);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(section);
        }

        // GET: Section/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Section section = _context.Sections.Single(m => m.Id == id);
            if (section == null)
            {
                return HttpNotFound();
            }

            return View(section);
        }

        // POST: Section/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Section section = _context.Sections.Single(m => m.Id == id);
            _context.Sections.Remove(section);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}