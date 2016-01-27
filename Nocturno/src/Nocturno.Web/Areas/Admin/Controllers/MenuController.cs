using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IMenuItemService _menuItemService;

        public MenuController(IMenuService menuService, IMenuItemService menuItemService)
        {
            _menuService = menuService;
            _menuItemService = menuItemService;
        }

        // GET: Menu
        public IActionResult Index()
        {
            var items = _menuItemService.GetAll();
            return View(items.ToList());
        }

        // GET: Menu/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MenuItem menuItem = _menuItemService.GetById(id);
            if (menuItem == null)
            {
                return HttpNotFound();
            }

            return View(menuItem);
        }

        // GET: Menu/Create
        public IActionResult Create()
        {
            ViewBag.Menu = new SelectList(_menuService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Menu/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                _menuItemService.Create(menuItem);
                _menuItemService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.Menu = new SelectList(_menuService.GetAll(), "Id", "Name", menuItem.MenuId);
            return View(menuItem);
        }

        // GET: Menu/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MenuItem menuItem = _menuItemService.GetById(id);
            if (menuItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.Menu = new SelectList(_menuService.GetAll(), "Id", "Name", menuItem.MenuId);
            return View(menuItem);
        }

        // POST: Menu/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                _menuItemService.Update(menuItem);
                _menuItemService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.Menu = new SelectList(_menuService.GetAll(), "Id", "Name", menuItem.MenuId);
            return View(menuItem);
        }

        // GET: Menu/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            MenuItem menuItem = _menuItemService.GetById(id);
            if (menuItem == null)
            {
                return HttpNotFound();
            }

            return View(menuItem);
        }

        // POST: Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            MenuItem menuItem = _menuItemService.GetById(id);
            _menuItemService.Delete(menuItem);
            _menuItemService.Commit();
            return RedirectToAction("Index");
        }
    }
}