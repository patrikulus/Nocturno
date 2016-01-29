using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class BusinessController : Controller
    {
        private NocturnoContext _context;

        public BusinessController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Businesses
        public IActionResult Index()
        {
            return View(_context.Businesses.ToList());
        }

        // GET: Businesses/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Business business = _context.Businesses.Single(m => m.Id == id);
            if (business == null)
            {
                return HttpNotFound();
            }

            return View(business);
        }

        // GET: Businesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Businesses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Business business)
        {
            if (ModelState.IsValid)
            {
                _context.Businesses.Add(business);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(business);
        }

        // GET: Businesses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Business business = _context.Businesses.Single(m => m.Id == id);
            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // POST: Businesses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Business business)
        {
            if (ModelState.IsValid)
            {
                _context.Update(business);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(business);
        }

        // GET: Businesses/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Business business = _context.Businesses.Single(m => m.Id == id);
            if (business == null)
            {
                return HttpNotFound();
            }

            return View(business);
        }

        // POST: Businesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Business business = _context.Businesses.Single(m => m.Id == id);
            _context.Businesses.Remove(business);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}