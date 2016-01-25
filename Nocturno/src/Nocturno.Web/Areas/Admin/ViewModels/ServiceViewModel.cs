using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<Data.Models.Service> Services { get; set; }
        public IEnumerable<Data.Models.ServiceItem> ServiceItems { get; set; }
    }
}