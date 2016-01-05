using Nocturno.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class PortfolioItem : BaseContent
    {
        public int PortfolioId { get; set; }
        public string Hyperlink { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}