using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Business : BaseEntity
    {
        public ICollection<BusinessItem> BusinessItems { get; set; }
        public ICollection<BusinessNode> BusinessNodes { get; set; }
    }
}