using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class PageSection
    {
        public int SectionId { get; set; }
        public int PageId { get; set; }

        public virtual Section Section { get; set; }
        public virtual Page Page { get; set; }
    }
}