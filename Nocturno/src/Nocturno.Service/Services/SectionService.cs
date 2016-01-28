using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
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

        public void AddPageSections(IEnumerable<string> sections, int pageId)
        {
            foreach (var sectionName in sections)
            {
                var section = _db.Sections.FirstOrDefault(x => x.Name == sectionName);
                _db.Nodes.Add(new Node
                {
                    PageId = pageId,
                    SectionId = section.Id
                });
            }
        }

        public List<Section> GetAllSectionsForPage(int? pageId)
        {
            if (pageId == null)
            {
                return new List<Section>();
            }
            List<Section> result = _db.Nodes.Where(x => x.PageId == pageId).Select(x => x.Section).ToList();
            return result;
        }

        public Dictionary<string, bool> GetAllSectionsForPageWithFlag(int? pageId)
        {
            if (pageId == null)
            {
                return null;
            }
            var result = GetAll().ToDictionary(section => section.Name, section => false);

            List<Section> sections = _db.Nodes.Where(x => x.PageId == pageId).Select(x => x.Section).ToList();

            foreach (var section in sections)
            {
                result[section.Name] = true;
            }
            return result;
        }

        public void UpdatePageSections(IEnumerable<string> sections, int pageId)
        {
            foreach (var sectionName in sections)
            {
                var section = _db.Sections.FirstOrDefault(x => x.Name == sectionName);
                if (!_db.Nodes.Any(x => x.PageId == pageId && x.SectionId == section.Id))
                {
                    _db.Nodes.Add(new Node
                    {
                        PageId = pageId,
                        SectionId = section.Id
                    });
                }
            }

            var collection = _db.Nodes.Where(x => x.PageId == pageId).Select(x => x.Section.Name);
            var difference = new List<string>();

            foreach (var item in collection)
            {
                if (!sections.Contains(item))
                {
                    difference.Add(item);
                }
            }

            foreach (var item in difference)
            {
                var sectionId = _db.Sections.FirstOrDefault(x => x.Name == item).Id;
                var node = _db.Nodes.FirstOrDefault(x => x.SectionId == sectionId && x.PageId == pageId);
                _db.Nodes.Remove(node);
            }
        }

        // TODO standarize -Node classes and do this via generic method
        public void AssignSections(SectionContentViewModel model)
        {
            if (model.SimpleTexts != null)
            {
                foreach (var simpleText in model.SimpleTexts)
                {
                    var id = _db.SimpleTexts.FirstOrDefault(x => x.Name == simpleText.Key).Id;
                    var binder = new SimpleTextNode
                    {
                        NodeId = model.NodeId,
                        SimpleTextId = id
                    };
                    _db.Set<SimpleTextNode>().Add(binder);
                }
            }

            if (model.Collections != null)
            {
                foreach (var collection in model.Collections)
                {
                    var id = _db.Collections.FirstOrDefault(x => x.Name == collection.Key).Id;
                    var binder = new CollectionNode
                    {
                        NodeId = model.NodeId,
                        CollectionId = id
                    };
                    _db.Set<CollectionNode>().Add(binder);
                }
            }

            if (model.Baners != null)
            {
                foreach (var baner in model.Baners)
                {
                    var id = _db.Baners.FirstOrDefault(x => x.Name == baner.Key).Id;
                    var binder = new BanerNode
                    {
                        NodeId = model.NodeId,
                        BanerId = id
                    };
                    _db.Set<BanerNode>().Add(binder);
                }
            }

            if (model.Businesses != null)
            {
                foreach (var business in model.Businesses)
                {
                    var id = _db.Businesses.FirstOrDefault(x => x.Name == business.Key).Id;
                    var binder = new BusinessNode
                    {
                        NodeId = model.NodeId,
                        BusinessId = id
                    };
                    _db.Set<BusinessNode>().Add(binder);
                }
            }

            if (model.Portfolios != null)
            {
                foreach (var portfolio in model.Portfolios)
                {
                    var id = _db.Portfolios.FirstOrDefault(x => x.Name == portfolio.Key).Id;
                    var binder = new PortfolioNode
                    {
                        NodeId = model.NodeId,
                        PortfolioId = id
                    };
                    _db.Set<PortfolioNode>().Add(binder);
                }
            }
        }

        public override Section GetByName(string name)
        {
            return _db.Sections.FirstOrDefault(x => x.Name == name);
        }
    }
}