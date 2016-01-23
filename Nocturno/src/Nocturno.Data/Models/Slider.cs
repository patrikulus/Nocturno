using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Slider : BaseEntity
    {
        public ICollection<SliderItem> SliderItems { get; set; }
        public ICollection<SliderNode> SliderNodes { get; set; }
    }
}