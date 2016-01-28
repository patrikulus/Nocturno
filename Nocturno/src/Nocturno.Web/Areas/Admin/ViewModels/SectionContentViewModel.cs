using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class SectionContentViewModel
    {
        public Dictionary<string, bool> SimpleTexts { get; set; }
        public Dictionary<string, bool> Baners { get; set; }
        public Dictionary<string, bool> Collections { get; set; }
        public Dictionary<string, bool> Portfolios { get; set; }
        public Dictionary<string, bool> Businesses { get; set; }

        public Node Node { get; set; }
    }
}