using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class SliderItem : MinimalContent
    {
        public string ImageUrl { get; set; }
        public string Hyperlink { get; set; }

        public int SliderId { get; set; }
        public Slider Slider { get; set; }
    }
}