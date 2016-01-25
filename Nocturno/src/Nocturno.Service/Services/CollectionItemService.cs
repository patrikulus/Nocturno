using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class CollectionItemService : BaseService<CollectionItem>, ICollectionItemService
    {
        public CollectionItemService(IDbContext db) : base(db)
        {
        }

        public IEnumerable<CollectionItem> GetCollectionItems()
        {
            return _db.CollectionItems.Include(x => x.Collection).ToList();
        }
    }
}