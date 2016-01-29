using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioItemController : Controller
    {
        private NocturnoContext _context;

        public PortfolioItemController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: PortfolioItem
        public IActionResult Index()
        {
            var nocturnoContext = _context.PortfolioItems.Include(p => p.Portfolio);
            return View(nocturnoContext.ToList());
        }

        // GET: PortfolioItem/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PortfolioItem portfolioItem = _context.PortfolioItems.Single(m => m.Id == id);
            if (portfolioItem == null)
            {
                return HttpNotFound();
            }

            return View(portfolioItem);
        }

        // GET: PortfolioItem/Create
        public IActionResult Create()
        {
            ViewData["PortfolioId"] = new SelectList(_context.Portfolios, "Id", "Portfolio");
            return View();
        }

        // POST: PortfolioItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PortfolioItem portfolioItem)
        {
            if (ModelState.IsValid)
            {
                _context.PortfolioItems.Add(portfolioItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["PortfolioId"] = new SelectList(_context.Portfolios, "Id", "Portfolio", portfolioItem.PortfolioId);
            return View(portfolioItem);
        }

        // GET: PortfolioItem/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PortfolioItem portfolioItem = _context.PortfolioItems.Single(m => m.Id == id);
            if (portfolioItem == null)
            {
                return HttpNotFound();
            }
            ViewData["PortfolioId"] = new SelectList(_context.Portfolios, "Id", "Portfolio", portfolioItem.PortfolioId);
            return View(portfolioItem);
        }

        // POST: PortfolioItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PortfolioItem portfolioItem)
        {
            if (ModelState.IsValid)
            {
                _context.Update(portfolioItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["PortfolioId"] = new SelectList(_context.Portfolios, "Id", "Portfolio", portfolioItem.PortfolioId);
            return View(portfolioItem);
        }

        // GET: PortfolioItem/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PortfolioItem portfolioItem = _context.PortfolioItems.Single(m => m.Id == id);
            if (portfolioItem == null)
            {
                return HttpNotFound();
            }

            return View(portfolioItem);
        }

        // POST: PortfolioItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            PortfolioItem portfolioItem = _context.PortfolioItems.Single(m => m.Id == id);
            _context.PortfolioItems.Remove(portfolioItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}