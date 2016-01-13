using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Serv
{
    public class PageService : BaseService<Page>, IPageService
    {
        public PageService(IDbContext db) : base(db)
        {
        }
    }
}