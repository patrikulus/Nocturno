using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        private NocturnoContext _context;

        public SettingsController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Settings
        public IActionResult Index()
        {
            return View(_context.Properties.ToList());
        }

        // GET: Settings/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Setting setting = _context.Properties.Single(m => m.Id == id);
            if (setting == null)
            {
                return HttpNotFound();
            }

            return View(setting);
        }

        // GET: Settings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Settings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Setting setting)
        {
            if (ModelState.IsValid)
            {
                _context.Properties.Add(setting);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(setting);
        }

        // GET: Settings/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Setting setting = _context.Properties.Single(m => m.Id == id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        // POST: Settings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Setting setting)
        {
            if (ModelState.IsValid)
            {
                _context.Update(setting);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(setting);
        }

        // GET: Settings/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Setting setting = _context.Properties.Single(m => m.Id == id);
            if (setting == null)
            {
                return HttpNotFound();
            }

            return View(setting);
        }

        // POST: Settings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Setting setting = _context.Properties.Single(m => m.Id == id);
            _context.Properties.Remove(setting);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}