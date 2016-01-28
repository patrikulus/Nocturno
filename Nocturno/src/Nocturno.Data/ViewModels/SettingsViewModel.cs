using Nocturno.Data.Settings;
using System.Collections.Generic;

namespace Nocturno.Data.ViewModels
{
    public class SettingsViewModel
    {
        public NocturnoSettings NocturnoSettings { get; set; }
        public List<string> Themes { get; set; }
    }
}