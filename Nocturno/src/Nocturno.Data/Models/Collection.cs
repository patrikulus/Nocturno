using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Collection : BaseContent
    {
        public int SectionId { get; set; }

        public virtual Section Section { get; set; }
        public virtual ICollection<CollectionItem> Items { get; set; }
    }
}