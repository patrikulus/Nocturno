using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class BusinessItemController : Controller
    {
        private NocturnoContext _context;

        public BusinessItemController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: BusinessItems
        public IActionResult Index()
        {
            var nocturnoContext = _context.BusinessItems.Include(b => b.Business);
            return View(nocturnoContext.ToList());
        }

        // GET: BusinessItems/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BusinessItem businessItem = _context.BusinessItems.Single(m => m.Id == id);
            if (businessItem == null)
            {
                return HttpNotFound();
            }

            return View(businessItem);
        }

        // GET: BusinessItems/Create
        public IActionResult Create()
        {
            ViewData["BusinessId"] = new SelectList(_context.Businesses, "Id", "Business");
            return View();
        }

        // POST: BusinessItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BusinessItem businessItem)
        {
            if (ModelState.IsValid)
            {
                _context.BusinessItems.Add(businessItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["BusinessId"] = new SelectList(_context.Businesses, "Id", "Business", businessItem.BusinessId);
            return View(businessItem);
        }

        // GET: BusinessItems/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BusinessItem businessItem = _context.BusinessItems.Single(m => m.Id == id);
            if (businessItem == null)
            {
                return HttpNotFound();
            }
            ViewData["BusinessId"] = new SelectList(_context.Businesses, "Id", "Business", businessItem.BusinessId);
            return View(businessItem);
        }

        // POST: BusinessItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BusinessItem businessItem)
        {
            if (ModelState.IsValid)
            {
                _context.Update(businessItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["BusinessId"] = new SelectList(_context.Businesses, "Id", "Business", businessItem.BusinessId);
            return View(businessItem);
        }

        // GET: BusinessItems/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BusinessItem businessItem = _context.BusinessItems.Single(m => m.Id == id);
            if (businessItem == null)
            {
                return HttpNotFound();
            }

            return View(businessItem);
        }

        // POST: BusinessItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            BusinessItem businessItem = _context.BusinessItems.Single(m => m.Id == id);
            _context.BusinessItems.Remove(businessItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}