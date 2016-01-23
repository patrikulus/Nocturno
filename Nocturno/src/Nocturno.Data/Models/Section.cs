using Nocturno.Data.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Data.Models
{
    public class Section : BaseEntity
    {
        public ICollection<Node> Nodes { get; set; }
    }
}