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
    [Authorize(Roles = "Admin")]
    public class SettingsController : Controller
    {
        private readonly ISettingService _settingService;

        public SettingsController(ISettingService service)
        {
            _settingService = service;
        }

        // GET: Settings
        public IActionResult Index()
        {
            return View(_settingService.GetAll());
        }

        // GET: Settings/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Setting setting = _settingService.GetById(id);
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
                _settingService.Create(setting);
                _settingService.Commit();
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

            Setting setting = _settingService.GetById(id);
            if (setting == null)
            {
                return HttpNotFound();
            }

            if (setting.Name == "Site theme")
            {
                ViewBag.Themes = new SelectList(_settingService.GetAllAvailableThemes(), setting.Name);
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
                _settingService.Update(setting);
                _settingService.Commit();
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

            Setting setting = _settingService.GetById(id);
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
            Setting setting = _settingService.GetById(id);
            _settingService.Delete(setting);
            _settingService.Commit();
            return RedirectToAction("Index");
        }
    }
}