using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class BusinessNode
    {
        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}