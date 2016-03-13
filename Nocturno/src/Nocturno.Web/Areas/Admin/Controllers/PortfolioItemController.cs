using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using Nocturno.Service.IServices;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioItemController : Controller
    {
        private readonly IPortfolioItemService _portfolioItemService;
        private readonly IPortfolioService _portfolioService;

        public PortfolioItemController(IPortfolioItemService portfolioItemService, IPortfolioService portfolioService)
        {
            _portfolioItemService = portfolioItemService;
            _portfolioService = portfolioService;
        }

        // GET: PortfolioItem
        public IActionResult Index()
        {
            return View(_portfolioItemService.GetAll());
        }

        // GET: PortfolioItem/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PortfolioItem portfolioItem = _portfolioItemService.GetById(id);
            if (portfolioItem == null)
            {
                return HttpNotFound();
            }

            return View(portfolioItem);
        }

        // GET: PortfolioItem/Create
        public IActionResult Create()
        {
            ViewBag.PortfolioId = new SelectList(_portfolioService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: PortfolioItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PortfolioItem portfolioItem)
        {
            if (ModelState.IsValid)
            {
                _portfolioItemService.Create(portfolioItem);
                _portfolioItemService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.PortfolioId = new SelectList(_portfolioService.GetAll(), "Id", "Name", portfolioItem.PortfolioId);
            return View(portfolioItem);
        }

        // GET: PortfolioItem/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PortfolioItem portfolioItem = _portfolioItemService.GetById(id);
            if (portfolioItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.PortfolioId = new SelectList(_portfolioService.GetAll(), "Id", "Name", portfolioItem.PortfolioId);
            return View(portfolioItem);
        }

        // POST: PortfolioItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PortfolioItem portfolioItem)
        {
            if (ModelState.IsValid)
            {
                _portfolioItemService.Update(portfolioItem);
                _portfolioItemService.Commit();
                return RedirectToAction("Index");
            }
            ViewBag.PortfolioId = new SelectList(_portfolioService.GetAll(), "Id", "Name", portfolioItem.PortfolioId);
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

            PortfolioItem portfolioItem = _portfolioItemService.GetById(id);
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
            PortfolioItem portfolioItem = _portfolioItemService.GetById(id);
            _portfolioItemService.Delete(portfolioItem);
            _portfolioItemService.Commit();
            return RedirectToAction("Index");
        }
    }
}