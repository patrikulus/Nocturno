using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class SimpleTextNode
    {
        public int SimpleTextId { get; set; }
        public SimpleText SimpleText { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}