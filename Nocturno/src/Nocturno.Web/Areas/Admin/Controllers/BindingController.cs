using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Model.Models;
using Nocturno.Web.Models;

namespace Nocturno.Web.Controllers
{
    public class BindingController : Controller
    {
        private NocturnoContext _context;

        public BindingController(NocturnoContext context)
        {
            _context = context;    
        }

        // GET: Binding
        public IActionResult Index()
        {
            var nocturnoContext = _context.SectionsToPages.Include(s => s.Page).Include(s => s.Section);
            return View(nocturnoContext.ToList());
        }

        // GET: Binding/Details/5
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

        // GET: Binding/Create
        public IActionResult Create()
        {
            ViewData["PageId"] = new SelectList(_context.Pages, "Id", "Page");
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Section");
            return View();
        }

        // POST: Binding/Create
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
            ViewData["PageId"] = new SelectList(_context.Pages, "Id", "Page", sectionToPage.PageId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Section", sectionToPage.SectionId);
            return View(sectionToPage);
        }

        // GET: Binding/Edit/5
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
            ViewData["PageId"] = new SelectList(_context.Pages, "Id", "Page", sectionToPage.PageId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Section", sectionToPage.SectionId);
            return View(sectionToPage);
        }

        // POST: Binding/Edit/5
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
            ViewData["PageId"] = new SelectList(_context.Pages, "Id", "Page", sectionToPage.PageId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Section", sectionToPage.SectionId);
            return View(sectionToPage);
        }

        // GET: Binding/Delete/5
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

        // POST: Binding/Delete/5
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
