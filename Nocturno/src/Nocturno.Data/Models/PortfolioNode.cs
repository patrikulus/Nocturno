using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class PortfolioNode
    {
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}