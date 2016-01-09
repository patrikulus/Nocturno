using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Model.Models;
using Nocturno.Web.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class SectionToPageController : Controller
    {
        private NocturnoContext _context;

        public SectionToPageController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: SectionToPage
        public IActionResult Index()
        {
            var nocturnoContext = _context.SectionsToPages.Include(s => s.Page).Include(s => s.Section);
            return View(nocturnoContext.ToList());
        }

        // GET: SectionToPage/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SectionToPage sectionToPage = _context.SectionsToPages.Single(m => m.Id == id);
            if (sectionToPage == null)
            {
                return HttpNotFound();
            }

            return View(sectionToPage);
        }

        // GET: SectionToPage/Create
        public IActionResult Create()
        {
            ViewBag.PageId = new SelectList(_context.Pages, "Id", "Name");
            ViewBag.SectionId = new SelectList(_context.Sections, "Id", "Name");
            return View();
        }

        // POST: SectionToPage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SectionToPage sectionToPage)
        {
            if (ModelState.IsValid)
            {
                _context.SectionsToPages.Add(sectionToPage);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PageId = new SelectList(_context.Pages, "Id", "Name", sectionToPage.PageId);
            ViewBag.SectionId = new SelectList(_context.Sections, "Id", "Name", sectionToPage.SectionId);
            return View(sectionToPage);
        }

        // GET: SectionToPage/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SectionToPage sectionToPage = _context.SectionsToPages.Single(m => m.Id == id);
            if (sectionToPage == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageId = new SelectList(_context.Pages, "Id", "Name", sectionToPage.PageId);
            ViewBag.SectionId = new SelectList(_context.Sections, "Id", "Name", sectionToPage.SectionId);
            return View(sectionToPage);
        }

        // POST: SectionToPage/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SectionToPage sectionToPage)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sectionToPage);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PageId = new SelectList(_context.Pages, "Id", "Name", sectionToPage.PageId);
            ViewBag.SectionId = new SelectList(_context.Sections, "Id", "Name", sectionToPage.SectionId);
            return View(sectionToPage);
        }

        // GET: SectionToPage/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SectionToPage sectionToPage = _context.SectionsToPages.Single(m => m.Id == id);
            if (sectionToPage == null)
            {
                return HttpNotFound();
            }

            return View(sectionToPage);
        }

        // POST: SectionToPage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            SectionToPage sectionToPage = _context.SectionsToPages.Single(m => m.Id == id);
            _context.SectionsToPages.Remove(sectionToPage);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}