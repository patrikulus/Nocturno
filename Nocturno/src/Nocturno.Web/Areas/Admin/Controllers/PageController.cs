using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Models;
using Nocturno.Repository.Context;
using Nocturno.Web.ViewModels.Page;
using System.Collections.Generic;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        private NocturnoContext _context;

        public PageController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Page
        public IActionResult Index()
        {
            return View(_context.Pages.ToList());
        }

        // GET: Page/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Page page = _context.Pages.Single(m => m.Id == id);
            ICollection<Section> sections = _context.Sections.ToList();
            DetailsViewModel dvm = new DetailsViewModel
            {
                Page = page,
                Sections = sections
            };

            if (page == null)
            {
                return HttpNotFound();
            }

            return View(dvm);
        }

        // GET: Page/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Page/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Page page)
        {
            if (ModelState.IsValid)
            {
                _context.Pages.Add(page);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(page);
        }

        // GET: Page/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Page page = _context.Pages.Single(m => m.Id == id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: Page/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Page page)
        {
            if (ModelState.IsValid)
            {
                _context.Update(page);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(page);
        }

        // GET: Page/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Page page = _context.Pages.Single(m => m.Id == id);
            if (page == null)
            {
                return HttpNotFound();
            }

            return View(page);
        }

        // POST: Page/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Page page = _context.Pages.Single(m => m.Id == id);
            _context.Pages.Remove(page);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}