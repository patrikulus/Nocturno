using Nocturno.Data.Models;
using System.Collections.Generic;

namespace Nocturno.Data.ViewModels
{
    public class PageViewModel
    {
        public Page Page { get; set; }
        public List<Section> Sections { get; set; }
        public Dictionary<string, bool> ActiveSections { get; set; }
        public bool IsInMenu { get; set; }
    }
}