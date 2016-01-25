using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Collection : BaseEntity
    {
        public string CollectionType { get; set; }

        public ICollection<CollectionItem> CollectionItems { get; set; }
        public ICollection<CollectionNode> CollectionNodes { get; set; }
    }
}