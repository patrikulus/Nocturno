using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.BaseModels
{
    public class MinimalContent : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}