using Nocturno.Data.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class SettingsViewModel
    {
        public NocturnoSettings NocturnoSettings { get; set; }
        public List<string> Themes { get; set; }
    }
}