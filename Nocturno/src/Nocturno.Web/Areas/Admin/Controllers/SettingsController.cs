using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using Microsoft.Extensions.PlatformAbstractions;
using Nocturno.Data.Settings;
using Nocturno.Service.IServices;
using Nocturno.Web.Areas.Admin.ViewModels;
using System.IO;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        private readonly ISettingService _settingService;
        private NocturnoSettings _options;
        private IApplicationEnvironment _environment;
        private readonly string _configPath;

        public SettingsController(ISettingService settingService, IOptions<NocturnoSettings> optionsAccessor, IApplicationEnvironment environment)
        {
            _settingService = settingService;
            _options = optionsAccessor.Value;
            _environment = environment;
            _configPath = Path.Combine(_environment.ApplicationBasePath, "nocturnosettings.json");
        }

        // GET: Settings
        public IActionResult Index()
        {
            _options.SiteName = "foo";
            _settingService.UpdateConfig(_options, _configPath);
            var model = new SettingsViewModel
            {
                NocturnoSettings = _options,
                Themes = _settingService.GetAllAvailableThemes()
            };

            return View(model);
        }
    }
}