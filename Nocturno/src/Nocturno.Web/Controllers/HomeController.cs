using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string page)
        {
            if (string.IsNullOrWhiteSpace(page))
            {
                page = string.Empty;
            }
            return View("Index", page);
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