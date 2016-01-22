using Microsoft.AspNet.Hosting;
using Newtonsoft.Json;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.Settings;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Nocturno.Service.Services
{
    public class SettingService : ISettingService
    {
        private readonly IDbContext _db;
        private readonly IHostingEnvironment _environment;
        private const string ThemesPath = "css/themes";

        public SettingService(IDbContext db, IHostingEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        public List<string> GetAllAvailableThemes()
        {
            var content = _environment.WebRootFileProvider.GetDirectoryContents(ThemesPath);
            var themes = content.Select(x => x.Name).ToList();
            return themes;
        }

        public void UpdateConfig(NocturnoSettings settings, string configPath)
        {
            JsonSerializer serializer = new JsonSerializer();
            NocturnoSettings NocturnoSettings = settings;

            using (StreamWriter sw = new StreamWriter(new FileStream(configPath, FileMode.Create)))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, new { NocturnoSettings });
                }
            }
        }
    }
}