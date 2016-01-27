using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Web.Areas.Admin.ViewModels;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class CollectionController : Controller
    {
        private readonly ICollectionItemService _collectionItemService;
        private readonly ICollectionService _collectionService;

        public CollectionController(ICollectionService collectionService, ICollectionItemService collectionItemService)
        {
            _collectionService = collectionService;
            _collectionItemService = collectionItemService;
        }

        // GET: Collections
        public IActionResult Index()
        {
            var model = new CollectionViewModel
            {
                Collections = _collectionService.GetAll(),
                CollectionItems = _collectionItemService.GetCollectionItems()
            };
            return View(model);
        }

        // GET: Collections/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Collection collection = _collectionService.GetById(id);
            if (collection == null)
            {
                return HttpNotFound();
            }

            return View(collection);
        }

        // GET: Collections/Create
        public IActionResult Create()
        {
            ViewBag.CollectionTypes = new SelectList(_collectionService.GetAllCollectionTypes());
            return View();
        }

        // POST: Collections/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Collection collection)
        {
            if (ModelState.IsValid)
            {
                _collectionService.Create(collection);
                _collectionService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.CollectionTypes = new SelectList(_collectionService.GetAllCollectionTypes());
            return View(collection);
        }

        // GET: Collections/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Collection collection = _collectionService.GetById(id);
            if (collection == null)
            {
                return HttpNotFound();
            }
            ViewBag.CollectionTypes = new SelectList(_collectionService.GetAllCollectionTypes());
            return View(collection);
        }

        // POST: Collections/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Collection collection)
        {
            if (ModelState.IsValid)
            {
                _collectionService.Update(collection);
                _collectionService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.CollectionTypes = new SelectList(_collectionService.GetAllCollectionTypes());
            return View(collection);
        }

        // GET: Collections/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Collection collection = _collectionService.GetById(id);
            if (collection == null)
            {
                return HttpNotFound();
            }

            return View(collection);
        }

        // POST: Collections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Collection collection = _collectionService.GetById(id);
            _collectionService.Delete(collection);
            _collectionService.Commit();
            return RedirectToAction("Index");
        }
    }
}