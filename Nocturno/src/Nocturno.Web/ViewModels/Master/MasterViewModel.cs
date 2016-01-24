using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.ViewModels.Master
{
    public class MasterViewModel
    {
        public IEnumerable<Data.Models.Section> Sections { get; set; }
        public Menu Menu { get; set; }
        public IDictionary<string, Node> Nodes { get; set; }

        //public Node Navigation { get; set; }
        //public Node HeaderTop { get; set; }
        //public Node Breadcrumb { get; set; }
        //public Node HeaderBottom { get; set; }
        //public Node MainTop { get; set; }
        //public Node MainMiddle { get; set; }
        //public Node MainBottom { get; set; }
        //public Node LeftSidebar { get; set; }
        //public Node RightSidebar { get; set; }
        //public Node FooterTop { get; set; }
        //public Node FooterBottom { get; set; }
    }
}