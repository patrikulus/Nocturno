using Nocturno.Web.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class SettingsViewModel
    {
        public AppSettings AppSettings { get; set; }
        public List<string> Themes { get; set; }
    }
}