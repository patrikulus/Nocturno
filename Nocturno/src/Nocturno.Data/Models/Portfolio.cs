using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Portfolio : BaseEntity
    {
        public ICollection<PortfolioItem> PortfolioItems { get; set; }
        public ICollection<PortfolioNode> PortfolioNodes { get; set; }
    }
}