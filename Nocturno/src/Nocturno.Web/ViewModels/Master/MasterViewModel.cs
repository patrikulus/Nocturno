using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.ViewModels.Master
{
    public class MasterViewModel
    {
        public IEnumerable<Data.Models.Section> Sections { get; set; }
        public Menu Menu { get; set; }
    }
}