using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Property : BaseEntity
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }
}