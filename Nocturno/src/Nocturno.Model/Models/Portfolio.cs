using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class Portfolio
    {
        public int SectionId { get; set; }

        public virtual Section Section { get; set; }
        public virtual ICollection<PortfolioItem> PortfolioItems { get; set; }
    }
}