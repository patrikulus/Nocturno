using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class CollectionItem : MinimalContent
    {
        public string Synopsis { get; set; }
        public string Icon { get; set; }
        public string Hyperlink { get; set; }

        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}