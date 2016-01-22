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
    public class ContentTypeController : Controller
    {
        private readonly IContentTypeService _contentTypeService;

        public ContentTypeController(IContentTypeService service)
        {
            _contentTypeService = service;
        }

        // GET: ContentType
        public IActionResult Index()
        {
            return View(_contentTypeService.GetAll());
        }

        // GET: ContentType/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CmsContentType cmsContentType = _contentTypeService.GetById(id);
            if (cmsContentType == null)
            {
                return HttpNotFound();
            }

            return View(cmsContentType);
        }

        // GET: ContentType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContentType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CmsContentType cmsContentType)
        {
            if (ModelState.IsValid)
            {
                _contentTypeService.Create(cmsContentType);
                _contentTypeService.Commit();
                return RedirectToAction("Index");
            }
            return View(cmsContentType);
        }

        // GET: ContentType/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CmsContentType cmsContentType = _contentTypeService.GetById(id);
            if (cmsContentType == null)
            {
                return HttpNotFound();
            }
            return View(cmsContentType);
        }

        // POST: ContentType/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CmsContentType cmsContentType)
        {
            if (ModelState.IsValid)
            {
                _contentTypeService.Update(cmsContentType);
                _contentTypeService.Commit();
                return RedirectToAction("Index");
            }
            return View(cmsContentType);
        }

        // GET: ContentType/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CmsContentType cmsContentType = _contentTypeService.GetById(id);
            if (cmsContentType == null)
            {
                return HttpNotFound();
            }

            return View(cmsContentType);
        }

        // POST: ContentType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            CmsContentType cmsContentType = _contentTypeService.GetById(id);
            _contentTypeService.Delete(cmsContentType);
            _contentTypeService.Commit();
            return RedirectToAction("Index");
        }
    }
}