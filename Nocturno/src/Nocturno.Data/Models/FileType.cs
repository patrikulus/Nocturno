using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nocturno.Data.BaseModels;

namespace Nocturno.Data.Models
{
    public class FileType : BaseEntity
    {
        public string Extension { get; set; }
        public string Icon { get; set; }
    }
}
