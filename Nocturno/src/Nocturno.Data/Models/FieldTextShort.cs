using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class FieldTextShort
    {
        public int ContentId { get; set; }

        public virtual Content Content { get; set; }
    }
}