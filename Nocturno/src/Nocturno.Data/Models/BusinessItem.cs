using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class BusinessItem : MinimalContent
    {
        public string Header { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedInLink { get; set; }
        public string TwitterLink { get; set; }
        public string ImageUrl { get; set; }

        public int BusinessId { get; set; }
        public Business Business { get; set; }
    }
}