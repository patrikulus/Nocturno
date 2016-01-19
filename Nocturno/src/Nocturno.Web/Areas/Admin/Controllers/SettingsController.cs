using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        private NocturnoContext _context;

        public SettingsController(NocturnoContext context)
        {
            _context = context;
        }

        // GET: Settings
        public IActionResult Index()
        {
            return View(_context.Properties.ToList());
        }
    }
}