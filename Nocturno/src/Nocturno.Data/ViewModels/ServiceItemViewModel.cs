using Nocturno.Data.Models;
using System.Collections.Generic;

namespace Nocturno.Data.ViewModels
{
    public class ServiceItemViewModel
    {
        public CollectionItem ServiceItem { get; set; }
        public ICollection<Data.Models.Collection> Services { get; set; }
    }
}