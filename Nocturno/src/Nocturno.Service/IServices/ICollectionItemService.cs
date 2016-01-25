using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface ICollectionItemService : IBaseService<CollectionItem>
    {
        IEnumerable<CollectionItem> GetCollectionItems();
    }
}