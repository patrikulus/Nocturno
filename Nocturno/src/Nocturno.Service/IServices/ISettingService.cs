using Nocturno.Data.Models;
using Nocturno.Data.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface ISettingService
    {
        List<string> GetAllAvailableThemes();

        void UpdateConfig(NocturnoSettings settings, string configPath);
    }
}