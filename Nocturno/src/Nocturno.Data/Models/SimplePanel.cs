using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class SimplePanel : MinimalContent
    {
        public string Hyperlink { get; set; }

        public ICollection<SimplePanelNode> SimplePanelNodes { get; set; }
    }
}