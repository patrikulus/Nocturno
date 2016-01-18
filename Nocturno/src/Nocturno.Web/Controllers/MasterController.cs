using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
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
        private MenuService _service = new MenuService(new NocturnoContext());

        public IActionResult Index(string name, int? page)
        {
            var sections = new List<Section>
            {
                new Section {Name = "Navigation"},
                new Section {Name = "Breadcrumb"}
            };
            var model = new MasterViewModel
            {
                Sections = sections,
                Menu = _service.GetMainMenu()
            };

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