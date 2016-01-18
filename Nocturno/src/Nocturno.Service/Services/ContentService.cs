using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class ContentService : BaseService<CmsContentTypeToFieldType>
    {
        public ContentService(IDbContext db) : base(db)
        {
        }
    }
}