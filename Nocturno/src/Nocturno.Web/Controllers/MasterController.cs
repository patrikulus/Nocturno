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

        public MasterController(IMenuService menuService, IPageService pageService, ISectionService sectionService)
        {
            _menuService = menuService;
            _pageService = pageService;
            _sectionService = sectionService;
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
                return View("Error");
            }

            var sections = _sectionService.GetAllSectionsForPage(currentPage.Id);

            var model = new MasterViewModel
            {
                Sections = sections,
                Menu = _menuService.GetMainMenu(),
                Nodes = _pageService.GetNodesDictionary(name)
            };

            // TestData

            // End TestData
            return View("MasterPage", model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}