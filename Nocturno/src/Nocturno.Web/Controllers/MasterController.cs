using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Index(string name, int? page)
        {
            var model = new List<Section>
            {
                new Section {Name = "Navigation"},
                new Section {Name = "Breadcrumb"}
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