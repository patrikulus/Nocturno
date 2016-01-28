using Nocturno.Data.Models;
using System.Collections.Generic;

namespace Nocturno.Data.ViewModels
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