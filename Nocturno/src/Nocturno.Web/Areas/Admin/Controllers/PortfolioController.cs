using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        private NocturnoContext _context;

        public PortfolioController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Portfolios
        public IActionResult Index()
        {
            return View(_context.Portfolios.ToList());
        }

        // GET: Portfolios/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Portfolio portfolio = _context.Portfolios.Single(m => m.Id == id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }

            return View(portfolio);
        }

        // GET: Portfolios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Portfolios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                _context.Portfolios.Add(portfolio);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfolio);
        }

        // GET: Portfolios/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Portfolio portfolio = _context.Portfolios.Single(m => m.Id == id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }
            return View(portfolio);
        }

        // POST: Portfolios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                _context.Update(portfolio);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfolio);
        }

        // GET: Portfolios/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Portfolio portfolio = _context.Portfolios.Single(m => m.Id == id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Portfolio portfolio = _context.Portfolios.Single(m => m.Id == id);
            _context.Portfolios.Remove(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}