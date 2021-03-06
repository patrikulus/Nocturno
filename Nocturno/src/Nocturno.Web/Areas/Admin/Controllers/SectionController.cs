using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using Nocturno.Service.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class SectionController : Controller
    {
        private readonly IPageService _pageService;
        private readonly ISectionService _sectionService;
        private readonly ISimpleTextService _simpleTextService;
        private readonly ICollectionService _collectionService;
        private readonly INodeService _nodeService;

        public SectionController(
            IPageService pageService,
            ISectionService sectionService,
            ISimpleTextService simpleTextService,
            ICollectionService collectionService,
            INodeService nodeService)
        {
            _pageService = pageService;
            _sectionService = sectionService;
            _simpleTextService = simpleTextService;
            _collectionService = collectionService;
            _nodeService = nodeService;
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
            var model = _sectionService.CreateModel(_nodeService.GetNodeId(page, sectionId));
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(SectionContentViewModel model)
        {
            _sectionService.UpdateAssignement(model);
            _sectionService.Commit();
            return RedirectToAction("Index");
        }
    }
}