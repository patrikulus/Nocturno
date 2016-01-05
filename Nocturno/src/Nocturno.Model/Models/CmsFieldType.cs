using Nocturno.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class CmsFieldType : BaseEntity
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}