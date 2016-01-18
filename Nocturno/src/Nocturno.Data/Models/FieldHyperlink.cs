using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class FieldHyperlink : BaseEntity
    {
        public string Link { get; set; }
        public string Description { get; set; }
        public bool OpenInNewTab { get; set; }
    }
}