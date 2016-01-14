using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Web.ViewModels.Page;
using System.Collections.Generic;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        private readonly IPageService _pageService;
        private readonly ISectionService _sectionService;

        public PageController(IPageService pageService, ISectionService sectionService)
        {
            _pageService = pageService;
            _sectionService = sectionService;
        }

        // GET: Page
        public IActionResult Index()
        {
            return View(_pageService.GetAll().ToList());
        }

        // GET: Page/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Page page = _pageService.GetById(id);
            ICollection<Section> sections = _sectionService.GetAll().ToList();
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
                _pageService.Create(page);
                _pageService.Commit();
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

            Page page = _pageService.GetById(id);
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
                _pageService.Update(page);
                _pageService.Commit();
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

            Page page = _pageService.GetById(id);
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
            Page page = _pageService.GetById(id);
            _pageService.Delete(page);
            _pageService.Commit();
            return RedirectToAction("Index");
        }
    }
}