using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class BusinessServie : BaseService<Business>, IBusinessService
    {
        public BusinessServie(IDbContext db) : base(db)
        {
        }
    }
}