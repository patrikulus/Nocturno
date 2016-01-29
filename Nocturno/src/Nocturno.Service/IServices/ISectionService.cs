using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface ISectionService : IBaseService<Section>
    {
        void AddPageSections(IEnumerable<string> sections, int pageId);

        List<Section> GetAllSectionsForPage(int? pageId);

        Dictionary<string, bool> GetAllSectionsForPageWithFlag(int? pageId);

        void UpdatePageSections(IEnumerable<string> sections, int pageId);

        void UpdateAssignement(SectionContentViewModel model);

        SectionContentViewModel CreateModel(int nodeId);
    }
}