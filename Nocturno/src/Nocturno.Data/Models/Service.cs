using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Service : BaseEntity
    {
        public ICollection<ServiceItem> ServiceItems { get; set; }
        public ICollection<ServiceNode> ServiceNodes { get; set; }
    }
}