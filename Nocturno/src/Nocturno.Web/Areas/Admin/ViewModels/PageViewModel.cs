using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class PageViewModel
    {
        public Page Page { get; set; }
        public List<Section> Sections { get; set; }
        public Dictionary<string, bool> ActiveSections { get; set; }
        public bool IsInMenu { get; set; }
    }
}