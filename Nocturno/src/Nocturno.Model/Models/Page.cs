using Nocturno.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class Page : BaseEntity
    {
        public virtual ICollection<Section> Sections { get; set; }
    }
}