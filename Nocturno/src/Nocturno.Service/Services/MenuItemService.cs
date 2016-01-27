using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class MenuItemService : BaseService<MenuItem>, IMenuItemService
    {
        public MenuItemService(IDbContext db) : base(db)
        {
        }
    }
}