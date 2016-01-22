using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Nocturno.Data.Settings
{
    public class NocturnoSettings
    {
        public string SiteName { get; set; }
        public string SiteLogo { get; set; }
        public string SiteTheme { get; set; }
        public string AdminTheme { get; set; }
    }
}