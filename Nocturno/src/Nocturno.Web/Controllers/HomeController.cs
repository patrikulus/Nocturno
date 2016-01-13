using Microsoft.AspNet.Mvc;
using Nocturno.Repository.Context;
using Nocturno.Repository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new NocturnoContext();
            var repo = new PageRepo(context);
            //var page = repo.GetAll().FirstOrDefault(x => x.Name == "Home");
            //var section = context.Sections.FirstOrDefault(x => x.Name == "Menu");
            //repo.AddSectionToPage(section, page);
            return View();
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