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

        public List<Section> GetAllSectionsForPage(int? pageId)
        {
            if (pageId == null)
            {
                return new List<Section>();
            }
            List<Section> result = _db.SectionsToPages.Where(x => x.PageId == pageId).Select(x => x.Section).ToList();
            return result;
        }

        public void AddPageSections(IEnumerable<string> sections, int pageId)
        {
            foreach (var sectionName in sections)
            {
                var section = _db.Sections.FirstOrDefault(x => x.Name == sectionName);
                _db.SectionsToPages.Add(new SectionToPage
                {
                    PageId = pageId,
                    SectionId = section.Id
                });
            }
        }

        public void UpdatePageSections(IEnumerable<string> sections, int pageId)
        {
            foreach (var sectionName in sections)
            {
                var section = _db.Sections.FirstOrDefault(x => x.Name == sectionName);
                if (!_db.SectionsToPages.Any(x => x.PageId == pageId && x.SectionId == section.Id))
                {
                    _db.SectionsToPages.Add(new SectionToPage
                    {
                        PageId = pageId,
                        SectionId = section.Id
                    });
                }
            }

            var collection = _db.SectionsToPages.Where(x => x.PageId == pageId).Select(x => x.Section.Name);
            var difference = collection.Except(sections);

            foreach (var item in difference)
            {
                var sectionId = _db.Sections.FirstOrDefault(x => x.Name == item).Id;
                var section = _db.SectionsToPages.FirstOrDefault(x => x.SectionId == sectionId && x.PageId == pageId);
                _db.SectionsToPages.Remove(section);
            }
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