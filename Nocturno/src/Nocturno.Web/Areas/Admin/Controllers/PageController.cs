using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Http.Internal;
using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using Nocturno.Service.IServices;
using Nocturno.Web.ViewModels.Page;
using System.Collections.Generic;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class PageController : Controller
    {
        private readonly IPageService _pageService;
        private readonly ISectionService _sectionService;
        private readonly IMenuService _menuService;

        public PageController(IPageService pageService, ISectionService sectionService, IMenuService menuService)
        {
            _pageService = pageService;
            _sectionService = sectionService;
            _menuService = menuService;
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
            if (page == null)
            {
                return HttpNotFound();
            }

            PageViewModel model = new PageViewModel
            {
                Page = page,
                Sections = _sectionService.GetAllSectionsForPage(id),
                IsInMenu = _menuService.CheckIfPageExistsInMenu(page)
            };

            return View(model);
        }

        // GET: Page/Create
        public IActionResult Create()
        {
            var model = new PageViewModel
            {
                Page = null,
                Sections = _sectionService.GetAll().ToList(),
                ActiveSections = _sectionService.GetAllSectionsForPageWithFlag(null),
                IsInMenu = true
            };
            return View(model);
        }

        // POST: Page/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PageViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pageService.Create(model.Page);
                var sections = model.ActiveSections.Where(x => x.Value == true).Select(x => x.Key);
                _sectionService.AddPageSections(sections, model.Page.Id);
                if (model.IsInMenu)
                {
                    _menuService.AddToMenu(model.Page);
                }
                _pageService.Commit();
                return RedirectToAction("Index");
            }
            return View(model.Page);
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

            var model = new PageViewModel
            {
                Page = page,
                Sections = _sectionService.GetAll().ToList(),
                ActiveSections = _sectionService.GetAllSectionsForPageWithFlag(id),
                IsInMenu = _menuService.CheckIfPageExistsInMenu(page)
            };

            return View(model);
        }

        // POST: Page/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PageViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pageService.Update(model.Page);
                var sections = model.ActiveSections.Where(x => x.Value == true).Select(x => x.Key);
                _sectionService.UpdatePageSections(sections, model.Page.Id);
                if (model.IsInMenu)
                {
                    _menuService.AddToMenu(model.Page);
                }
                else
                {
                    _menuService.RemoveFromMenu(model.Page);
                }
                _pageService.Commit();
                return RedirectToAction("Index");
            }
            return View(model.Page);
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