using Microsoft.AspNet.Hosting;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}