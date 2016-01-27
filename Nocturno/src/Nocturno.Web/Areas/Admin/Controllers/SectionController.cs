using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Web.Areas.Admin.ViewModels;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class SectionController : Controller
    {
        private readonly IPageService _pageService;
        private readonly ISectionService _sectionService;

        public SectionController(IPageService pageService, ISectionService sectionService)
        {
            _pageService = pageService;
            _sectionService = sectionService;
        }

        // GET: Section
        public IActionResult Index(SectionViewModel model)
        {
            if (model.PageId == null)
            {
                ViewBag.Pages = new SelectList(_pageService.GetAll(), "Id", "Name");
                var emptyModel = new SectionViewModel();
                return View("Page", emptyModel);
            }

            model.Sections = _sectionService.GetAllSectionsForPage(model.PageId);
            return View(model);
        }

        public IActionResult Edit(string section, int page)
        {
            var sectionId = _sectionService.GetByName(section).Id;
            var node =
            return View();
        }
    }
}