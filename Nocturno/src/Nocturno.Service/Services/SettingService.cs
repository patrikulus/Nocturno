using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
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

namespace Nocturno.Service.Services
{
    public class SettingService : BaseService<Setting>, ISettingService
    {
        private const string ThemesPath = "css/themes";

        private readonly IHostingEnvironment _environment;

        public SettingService(IDbContext db, IHostingEnvironment environment) : base(db)
        {
            _environment = environment;
        }

        public List<string> GetAllAvailableThemes()
        {
            var content = _environment.WebRootFileProvider.GetDirectoryContents(ThemesPath);
            var themes = content.Select(x => x.Name).ToList();
            return themes;
        }

        public IDictionary<string, string> GetAllSettingsDictionary()
        {
            var settings = GetAll();
            return settings.ToDictionary(setting => setting.Name, setting => setting.Value);
        }
    }
}