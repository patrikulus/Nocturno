using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Menu : BaseEntity
    {
        public int SectionId { get; set; }
        public Section Section { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}