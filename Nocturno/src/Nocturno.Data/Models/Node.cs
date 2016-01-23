using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Node
    {
        public int Id { get; set; }

        public int PageId { get; set; }
        public Page Page { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }

        public ICollection<BanerNode> BanerNodes { get; set; }
        public ICollection<BlogNode> BlogNodes { get; set; }
        public ICollection<BusinessNode> BusinessNodes { get; set; }
        public ICollection<PortfolioNode> PortfolioNodes { get; set; }
        public ICollection<ServiceNode> ServiceNodes { get; set; }
        public ICollection<SimplePanelNode> SimplePanelNodes { get; set; }
        public ICollection<SimpleTextNode> SimpleTextNodes { get; set; }
        public ICollection<SliderNode> SliderNodes { get; set; }
    }
}