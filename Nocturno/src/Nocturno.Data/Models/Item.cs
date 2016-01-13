using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Item : BaseContent
    {
        public int SectionId { get; set; }
        public string Header { get; set; }

        public virtual Section Section { get; set; }
    }
}