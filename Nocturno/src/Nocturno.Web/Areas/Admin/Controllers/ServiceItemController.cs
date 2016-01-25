using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemController : Controller
    {
        private NocturnoContext _context;

        public ServiceItemController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: ServiceItem
        public IActionResult Index()
        {
            var nocturnoContext = _context.ServiceItems.Include(s => s.Service);
            return View(nocturnoContext.ToList());
        }

        // GET: ServiceItem/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ServiceItem serviceItem = _context.ServiceItems.Single(m => m.Id == id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }

            return View(serviceItem);
        }

        // GET: ServiceItem/Create
        public IActionResult Create()
        {
            ViewBag.Services = new SelectList(_context.Services.ToList(), "Id", "Name");
            return View();
        }

        // POST: ServiceItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceItem serviceItem)
        {
            if (ModelState.IsValid)
            {
                _context.ServiceItems.Add(serviceItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Services = new SelectList(_context.Services, "Id", "Name", serviceItem.ServiceId);
            return View(serviceItem);
        }

        // GET: ServiceItem/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ServiceItem serviceItem = _context.ServiceItems.Single(m => m.Id == id);
            if (serviceItem == null)
            {
                return HttpNotFound();
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Service", serviceItem.ServiceId);
            return View(serviceItem);
        }

        // POST: ServiceItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServiceItem serviceItem)
        {
            if (ModelState.IsValid)
            {
                _context.Update(serviceItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Service", serviceItem.ServiceId);
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

            ServiceItem serviceItem = _context.ServiceItems.Single(m => m.Id == id);
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
            ServiceItem serviceItem = _context.ServiceItems.Single(m => m.Id == id);
            _context.ServiceItems.Remove(serviceItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}