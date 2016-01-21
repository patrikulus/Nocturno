using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.OptionsModel;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Web.Areas.Admin.ViewModels;
using Nocturno.Web.Settings;
using System.Linq;

namespace Nocturno.Web.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        private readonly ISettingService _settingService;
        private AppSettings _options;

        public SettingsController(ISettingService settingService, IOptions<AppSettings> optionsAccessor)
        {
            _settingService = settingService;
            _options = optionsAccessor.Value;
        }

        // GET: Settings
        public IActionResult Index()
        {
            var model = new SettingsViewModel
            {
                AppSettings = _options,
                Themes = _settingService.GetAllAvailableThemes()
            };

            return View(model);
        }
    }
}