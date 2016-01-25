using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class CollectionViewModel
    {
        public IEnumerable<Data.Models.Collection> Collections { get; set; }
        public IEnumerable<Data.Models.CollectionItem> CollectionItems { get; set; }
    }
}