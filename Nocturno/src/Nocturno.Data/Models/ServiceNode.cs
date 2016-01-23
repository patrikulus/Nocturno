using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class ServiceNode
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}