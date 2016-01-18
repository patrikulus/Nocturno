using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface ISectionService : IBaseService<Section>
    {
        Dictionary<string, bool> GetAllSectionsForPageWithFlag(int? pageId);

        List<Section> GetAllSectionsForPage(int? pageId);

        void AddPageSections(IEnumerable<string> sections, int pageId);

        void UpdatePageSections(IEnumerable<string> sections, int pageId);
    }
}