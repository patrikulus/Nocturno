using Microsoft.Data.Entity;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System.Collections.Generic;
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

        public IDictionary<string, Node> GetNodesDictionary(string name)
        {
            IDictionary<string, Node> result = new Dictionary<string, Node>();
            var page = _db.Pages.FirstOrDefault(x => x.Name == name);
            if (page == null)
            {
                return result;
            }

            var nodes = _db.Nodes
                .Where(x => x.PageId == page.Id)
                .Include(x => x.BlogNodes).ThenInclude(x => x.Blog).ThenInclude(x => x.Articles)
                .Include(x => x.BusinessNodes).ThenInclude(x => x.Business).ThenInclude(x => x.BusinessItems)
                .Include(x => x.PortfolioNodes).ThenInclude(x => x.Portfolio).ThenInclude(x => x.PortfolioItems)
                .Include(x => x.CollectionNodes).ThenInclude(x => x.Collection).ThenInclude(x => x.CollectionItems)
                .Include(x => x.SliderNodes).ThenInclude(x => x.Slider).ThenInclude(x => x.SliderItems)
                .Include(x => x.SimplePanelNodes).ThenInclude(x => x.SimplePanel)
                .Include(x => x.SimpleTextNodes).ThenInclude(x => x.SimpleText)
                .Include(x => x.BanerNodes).ThenInclude(x => x.Baner);

            foreach (var node in nodes)
            {
                result.Add(node.Section.Name, node);
            }

            return result;
        }
    }
}