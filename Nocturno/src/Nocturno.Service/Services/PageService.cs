using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System.Linq;

namespace Nocturno.Service.Services
{
    public class PageService : BaseService<Page>, IPageService
    {
        public PageService(IDbContext db) : base(db)
        {
        }

        public override Page GetById(int? id)
        {
            return _db.Pages.FirstOrDefault(x => x.Id == id);
        }
    }
}