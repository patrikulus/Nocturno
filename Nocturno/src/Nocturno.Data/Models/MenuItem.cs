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
        //public int SubmenuId { get; set; }

        public virtual Menu Menu { get; set; }
        //public virtual Menu Submenu { get; set; }
    }
}