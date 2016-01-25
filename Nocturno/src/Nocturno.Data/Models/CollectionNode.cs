using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class CollectionNode
    {
        public int CollectionId { get; set; }
        public Collection Collection { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}