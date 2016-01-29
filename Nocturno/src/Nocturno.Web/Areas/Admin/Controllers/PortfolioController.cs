using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using Nocturno.Service.IServices;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IPortfolioItemService _portfolioItemService;

        public PortfolioController(IPortfolioService portfolioService, IPortfolioItemService portfolioItemService)
        {
            _portfolioService = portfolioService;
            _portfolioItemService = portfolioItemService;
        }

        // GET: PortfolioItem
        public IActionResult Index()
        {
            var model = new PortfolioViewModel
            {
                Portfolios = _portfolioService.GetAll(),
                PortfolioItems = _portfolioItemService.GetAll()
            };
            return View(model);
        }

        // GET: Portfolios/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Portfolio portfolio = _portfolioService.GetById(id);
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
                _portfolioService.Create(portfolio);
                _portfolioService.Commit();
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

            Portfolio portfolio = _portfolioService.GetById(id);
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
                _portfolioService.Update(portfolio);
                _portfolioService.Commit();
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

            Portfolio portfolio = _portfolioService.GetById(id);
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
            Portfolio portfolio = _portfolioService.GetById(id);
            _portfolioService.Delete(portfolio);
            _portfolioService.Commit();
            return RedirectToAction("Index");
        }
    }
}