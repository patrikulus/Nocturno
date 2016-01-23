using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class SliderNode
    {
        public int SliderId { get; set; }
        public Slider Slider { get; set; }

        public int NodeId { get; set; }
        public Node Node { get; set; }
    }
}