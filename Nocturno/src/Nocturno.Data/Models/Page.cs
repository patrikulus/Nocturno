using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Page : BaseEntity
    {
        public virtual ICollection<SectionToPage> Sections { get; set; }
    }
}