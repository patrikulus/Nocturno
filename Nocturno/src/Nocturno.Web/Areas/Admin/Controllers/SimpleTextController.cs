using Microsoft.AspNet.Authorization;
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
    [Authorize(Roles = "Admin,Moderator")]
    public class SimpleTextController : Controller
    {
        private readonly ISimpleTextService _simpleTextService;

        public SimpleTextController(ISimpleTextService simpleTextService)
        {
            _simpleTextService = simpleTextService;
        }

        // GET: SimpleText
        public IActionResult Index()
        {
            return View(_simpleTextService.GetAll());
        }

        // GET: SimpleText/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SimpleText simpleText = _simpleTextService.GetById(id);
            if (simpleText == null)
            {
                return HttpNotFound();
            }

            return View(simpleText);
        }

        // GET: SimpleText/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SimpleText/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SimpleText simpleText)
        {
            if (ModelState.IsValid)
            {
                _simpleTextService.Create(simpleText);
                _simpleTextService.Commit();
                return RedirectToAction("Index");
            }
            return View(simpleText);
        }

        // GET: SimpleText/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SimpleText simpleText = _simpleTextService.GetById(id);
            if (simpleText == null)
            {
                return HttpNotFound();
            }
            return View(simpleText);
        }

        // POST: SimpleText/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SimpleText simpleText)
        {
            if (ModelState.IsValid)
            {
                _simpleTextService.Update(simpleText);
                _simpleTextService.Commit();
                return RedirectToAction("Index");
            }
            return View(simpleText);
        }

        // GET: SimpleText/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SimpleText simpleText = _simpleTextService.GetById(id);
            if (simpleText == null)
            {
                return HttpNotFound();
            }

            return View(simpleText);
        }

        // POST: SimpleText/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            SimpleText simpleText = _simpleTextService.GetById(id);
            _simpleTextService.Delete(simpleText);
            _simpleTextService.Commit();
            return RedirectToAction("Index");
        }
    }
}