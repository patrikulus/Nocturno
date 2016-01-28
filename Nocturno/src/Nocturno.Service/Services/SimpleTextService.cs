using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class SimpleTextService : BaseService<SimpleText>, ISimpleTextService
    {
        public SimpleTextService(IDbContext db) : base(db)
        {
        }
    }
}