using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;

namespace Nocturno.Service.Services
{
    public class PageService : BaseService<Page>, IPageService
    {
        public PageService(IDbContext db) : base(db)
        {
        }
    }
}