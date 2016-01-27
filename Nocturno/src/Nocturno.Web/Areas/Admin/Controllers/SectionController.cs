using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class SectionController : Controller
    {
        // GET: Section
        public IActionResult Index()
        {
            return View();
        }
    }
}