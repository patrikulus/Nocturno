using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class ServiceItem : MinimalContent
    {
        public string Synopsis { get; set; }
        public string IconUrl { get; set; }
        public string Hyperlink { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}