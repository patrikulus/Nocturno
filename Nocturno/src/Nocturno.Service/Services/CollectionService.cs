using Microsoft.AspNet.Mvc.Rendering;
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
    public class CollectionService : BaseService<Collection>, ICollectionService
    {
        public CollectionService(IDbContext db) : base(db)
        {
        }

        public IEnumerable<string> GetAllCollectionTypes()
        {
            var result = new List<string>
            {
                "Panel",
                "Big Icon",
                "Tab",
                "List"
            };
            return result;
        }
    }
}