using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Service.Services;
using Nocturno.Web.ViewModels.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Controllers
{
    public class MasterController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IPageService _pageService;
        private readonly ISectionService _sectionService;
        private readonly ISettingService _settingService;

        public MasterController(
            IMenuService menuService,
            IPageService pageService,
            ISectionService sectionService,
            ISettingService settingService)
        {
            _menuService = menuService;
            _pageService = pageService;
            _sectionService = sectionService;
            _settingService = settingService;
        }

        public IActionResult Index(string name, int? page)
        {
            var pages = _pageService.GetAll().ToList();
            if (name == null)
            {
                name = "Home";
            }

            var currentPage = pages.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (currentPage == null)
            {
                var settings = _settingService.GetAllSettingsDictionary();
                return View("Error", settings);
            }

            var sections = _sectionService.GetAllSectionsForPage(currentPage.Id);

            var model = new MasterViewModel
            {
                Sections = sections,
                Menu = _menuService.GetMainMenu(),
                Nodes = _pageService.GetNodesDictionary(name),
                Settings = _settingService.GetAllSettingsDictionary()
            };

            return View("MasterPage", model);
        }
    }
}