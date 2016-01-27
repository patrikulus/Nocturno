using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Web.Areas.Admin.ViewModels;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ServiceController : Controller
    {
        private NocturnoContext _context;

        public ServiceController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Collection
        public IActionResult Index()
        {
            var model = new CollectionViewModel
            {
                Collections = _context.Collections.ToList(),
                CollectionItems = _context.CollectionItems.Include(s => s.Collection).ToList()
            };
            return View(model);
        }

        // GET: Collection/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Data.Models.Collection service = _context.Collections.Single(m => m.Id == id);
            if (service == null)
            {
                return HttpNotFound();
            }

            return View(service);
        }

        // GET: Collection/Create
        public IActionResult Create()
        {
            ViewBag.ServiceTypes = null;
            return View();
        }

        // POST: Collection/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Data.Models.Collection service)
        {
            if (ModelState.IsValid)
            {
                _context.Collections.Add(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(service);
        }

        // GET: Collection/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Data.Models.Collection service = _context.Collections.Single(m => m.Id == id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // POST: Collection/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Data.Models.Collection service)
        {
            if (ModelState.IsValid)
            {
                _context.Update(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(service);
        }

        // GET: Collection/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Data.Models.Collection service = _context.Collections.Single(m => m.Id == id);
            if (service == null)
            {
                return HttpNotFound();
            }

            return View(service);
        }

        // POST: Collection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Data.Models.Collection service = _context.Collections.Single(m => m.Id == id);
            _context.Collections.Remove(service);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}