using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class ServiceItemViewModel
    {
        public ServiceItem ServiceItem { get; set; }
        public ICollection<Data.Models.Service> Services { get; set; }
    }
}