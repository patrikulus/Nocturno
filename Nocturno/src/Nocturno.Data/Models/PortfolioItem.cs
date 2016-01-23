using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class PortfolioItem : MinimalContent
    {
        public string ImageUrl { get; set; }

        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}