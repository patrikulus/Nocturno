using System.Collections.Generic;

namespace Nocturno.Data.ViewModels
{
    public class CollectionViewModel
    {
        public IEnumerable<Data.Models.Collection> Collections { get; set; }
        public IEnumerable<Data.Models.CollectionItem> CollectionItems { get; set; }
    }
}