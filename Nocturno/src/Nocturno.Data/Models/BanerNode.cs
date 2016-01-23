using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class BanerNode
    {
        public int BanerId { get; set; }
        public Baner Baner { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}