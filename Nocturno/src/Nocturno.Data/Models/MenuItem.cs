using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class MenuItem : BaseEntity
    {
        public string Hyperlink { get; set; }
        public int Order { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}