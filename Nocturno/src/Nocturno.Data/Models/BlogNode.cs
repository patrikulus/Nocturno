using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class BlogNode
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}