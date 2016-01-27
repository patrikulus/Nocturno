using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class CollectionItemController : Controller
    {
        private readonly ICollectionItemService _collectionItemService;
        private readonly ICollectionService _collectionService;
        private readonly IIconService _iconService;

        public CollectionItemController(
            ICollectionItemService collectionItemService,
            ICollectionService collectionService,
            IIconService iconService)
        {
            _collectionItemService = collectionItemService;
            _collectionService = collectionService;
            _iconService = iconService;
        }

        // GET: ServiceItem
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Collection");
        }

        // GET: ServiceItem/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CollectionItem serviceItem = _collectionItemService.GetById(id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }

            return View(serviceItem);
        }

        // GET: ServiceItem/Create
        public IActionResult Create()
        {
            ViewBag.Collections = new SelectList(_collectionService.GetAll(), "Id", "Name");
            ViewBag.Icons = new SelectList(_iconService.GetAll(), "Name", "Name");
            return View();
        }

        // POST: ServiceItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CollectionItem serviceItem)
        {
            if (ModelState.IsValid)
            {
                _collectionItemService.Create(serviceItem);
                _collectionItemService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.Services = new SelectList(_collectionService.GetAll(), "Id", "Name", serviceItem.CollectionId);
            ViewBag.Icons = new SelectList(_iconService.GetAll(), "Name", "Name", serviceItem.Icon);
            return View(serviceItem);
        }

        // GET: ServiceItem/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CollectionItem serviceItem = _collectionItemService.GetById(id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.Collections = new SelectList(_collectionService.GetAll(), "Id", "Name", serviceItem.CollectionId);
            ViewBag.Icons = new SelectList(_iconService.GetAll(), "Name", "Name", serviceItem.Icon);
            return View(serviceItem);
        }

        // POST: ServiceItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CollectionItem serviceItem)
        {
            if (ModelState.IsValid)
            {
                _collectionItemService.Update(serviceItem);
                _collectionItemService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.Collections = new SelectList(_collectionService.GetAll(), "Id", "Name", serviceItem.CollectionId);
            ViewBag.Icons = new SelectList(_iconService.GetAll(), "Name", "Name", serviceItem.Icon);
            return View(serviceItem);
        }

        // GET: ServiceItem/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CollectionItem serviceItem = _collectionItemService.GetById(id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }

            return View(serviceItem);
        }

        // POST: ServiceItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            CollectionItem serviceItem = _collectionItemService.GetById(id);
            _collectionItemService.Delete(serviceItem);
            _collectionItemService.Commit();
            return RedirectToAction("Index");
        }
    }
}