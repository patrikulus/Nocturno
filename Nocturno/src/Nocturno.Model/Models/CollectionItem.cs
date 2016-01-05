using Nocturno.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class CollectionItem : BaseContent
    {
        public int CollectionId { get; set; }
        public int Order { get; set; }
        public string Header { get; set; }
        public string Hyperlink { get; set; }

        public virtual Collection Collection { get; set; }
    }
}