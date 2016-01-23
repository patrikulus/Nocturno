using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Baner : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Text { get; set; }
        public string Hyperlink { get; set; }

        public ICollection<BanerNode> BanerNodes { get; set; }
    }
}