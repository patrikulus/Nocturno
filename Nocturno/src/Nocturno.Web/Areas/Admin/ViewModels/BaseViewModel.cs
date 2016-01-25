using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class BaseViewModel
    {
        public IDictionary<string, string> Settings { get; set; }
    }
}