using Nocturno.Data.Models;
using Nocturno.Data.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface ISettingService : IBaseService<Setting>
    {
        List<string> GetAllAvailableThemes();

        IDictionary<string, string> GetAllSettingsDictionary();
    }
}