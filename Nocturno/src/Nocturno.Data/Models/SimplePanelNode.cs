using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class SimplePanelNode
    {
        public int SimplePanelId { get; set; }
        public SimplePanel SimplePanel { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}