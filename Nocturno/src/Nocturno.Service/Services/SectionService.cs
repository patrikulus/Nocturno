using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class SectionService : BaseService<Section>, ISectionService
    {
        public SectionService(IDbContext db) : base(db)
        {
        }

        //public List<Section> GetAllSectionsForPageWithFlag(int? pageId)
        //{
        //    if (pageId == null)
        //    {
        //        return new List<Section>();
        //    }
        //    var collection = GetAll().Where(x => x.Pages.Any(y => y.PageId == pageId));
        //    return collection.ToList();
        //}
        public List<Section> GetAllSectionsForPage(int? pageId)
        {
            if (pageId == null)
            {
                return new List<Section>();
            }
            List<Section> result = _db.SectionsToPages.Where(x => x.PageId == pageId).Select(x => x.Section).ToList();
            return result;
        }

        public Dictionary<string, bool> GetAllSectionsForPageWithFlag(int? pageId)
        {
            if (pageId == null)
            {
                return null;
            }
            var result = GetAll().ToDictionary(section => section.Name, section => false);

            List<Section> collection = _db.SectionsToPages.Where(x => x.PageId == pageId).Select(x => x.Section).ToList();

            foreach (var section in collection)
            {
                result[section.Name] = true;
            }
            return result;
        }
    }
}