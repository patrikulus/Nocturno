using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.ViewModels
{
    public class PortfolioViewModel
    {
        public IEnumerable<Portfolio> Portfolios { get; set; }
        public IEnumerable<PortfolioItem> PortfolioItems { get; set; }
    }
}