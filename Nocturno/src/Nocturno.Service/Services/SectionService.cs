using Nocturno.Data.BaseModels;
using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        public override Section GetByName(string name)
        {
            return _db.Sections.FirstOrDefault(x => x.Name == name);
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

        public void UpdateAssignement(SectionContentViewModel model)
        {
            if (model.SimpleTexts != null)
            {
                var toAdd = GetItems<SimpleText>(model.SimpleTexts).Select(x => x.Id);
                var current = GetCurrent<SimpleTextNode>(model.NodeId).Select(x => x.SimpleTextId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<SimpleTextNode>(item, model.NodeId, new SimpleTextNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        //UnbindItem<SimpleTextNode>(item, model.NodeId);
                        var element = _db.Set<SimpleTextNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.SimpleTextId == item);
                        _db.Remove(element);
                    }
                }
            }

            if (model.Collections != null)
            {
                var toAdd = GetItems<Collection>(model.Collections).Select(x => x.Id);
                var current = GetCurrent<CollectionNode>(model.NodeId).Select(x => x.CollectionId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<CollectionNode>(item, model.NodeId, new CollectionNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        var element = _db.Set<CollectionNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.CollectionId == item);
                        _db.Remove(element);
                    }
                }
            }

            if (model.Baners != null)
            {
                var toAdd = GetItems<Baner>(model.Baners).Select(x => x.Id);
                var current = GetCurrent<BanerNode>(model.NodeId).Select(x => x.BanerId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<BanerNode>(item, model.NodeId, new BanerNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        var element = _db.Set<BanerNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.BanerId == item);
                        _db.Remove(element);
                    }
                }
            }

            if (model.Businesses != null)
            {
                var toAdd = GetItems<Business>(model.Businesses).Select(x => x.Id);
                var current = GetCurrent<BusinessNode>(model.NodeId).Select(x => x.BusinessId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<BusinessNode>(item, model.NodeId, new BusinessNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        var element = _db.Set<BanerNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.BanerId == item);
                        _db.Remove(element);
                    }
                }
            }

            if (model.Panels != null)
            {
                var toAdd = GetItems<SimplePanel>(model.Panels).Select(x => x.Id);
                var current = GetCurrent<SimplePanelNode>(model.NodeId).Select(x => x.SimplePanelId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<SimplePanelNode>(item, model.NodeId, new SimplePanelNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        var element = _db.Set<SimplePanelNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.SimplePanelId == item);
                        _db.Remove(element);
                    }
                }
            }

            if (model.Portfolios != null)
            {
                var toAdd = GetItems<Portfolio>(model.Portfolios).Select(x => x.Id);
                var current = GetCurrent<PortfolioNode>(model.NodeId).Select(x => x.PortfolioId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<PortfolioNode>(item, model.NodeId, new PortfolioNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        var element = _db.Set<PortfolioNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.PortfolioId == item);
                        _db.Remove(element);
                    }
                }
            }

            if (model.Sliders != null)
            {
                var toAdd = GetItems<Slider>(model.Sliders).Select(x => x.Id);
                var current = GetCurrent<SliderNode>(model.NodeId).Select(x => x.SliderId);

                foreach (var item in toAdd)
                {
                    if (!current.Contains(item))
                    {
                        BindItem<SliderNode>(item, model.NodeId, new SliderNode());
                    }
                }

                foreach (var item in current)
                {
                    if (!toAdd.Contains(item))
                    {
                        var element = _db.Set<SliderNode>()
                            .FirstOrDefault(x => x.NodeId == model.NodeId && x.SliderId == item);
                        _db.Remove(element);
                    }
                }
            }
        }

        public SectionContentViewModel CreateModel(int nodeId)
        {
            var model = new SectionContentViewModel();
            model.NodeId = nodeId;
            model.Collections = FillValue<Collection, CollectionNode>(nodeId);
            model.SimpleTexts = FillValue<SimpleText, SimpleTextNode>(nodeId);
            model.Baners = FillValue<Baner, BanerNode>(nodeId);
            model.Businesses = FillValue<Business, BusinessNode>(nodeId);
            model.Panels = FillValue<SimplePanel, SimplePanelNode>(nodeId);
            model.Portfolios = FillValue<Portfolio, PortfolioNode>(nodeId);
            model.Sliders = FillValue<Slider, SliderNode>(nodeId);

            return model;
        }

        private Dictionary<string, bool> FillValue<TContent, TBinder>(int nodeId)
            where TContent : class
            where TBinder : class
        {
            var items = _db.Set<TBinder>().Where(x => (int)x.GetType().GetProperty("NodeId").GetValue(x) == nodeId);
            var dictionary = _db.Set<TContent>().ToDictionary(x => x.GetType().GetProperty("Name").GetValue(x).ToString(), x => false);

            foreach (var binder in items)
            {
                var id = (int)binder.GetType()
                        .GetProperties()
                        .FirstOrDefault(x => x.Name.Contains("Id") && !x.Name.Contains("Node"))
                        .GetValue(binder);
                string key = GetNameById<TContent>(id);
                dictionary[key] = true;
            }
            return dictionary;
        }

        private string GetNameById<TContent>(int id) where TContent : class
        {
            var item = _db.Set<TContent>().FirstOrDefault(x => (int)x.GetType().GetProperty("Id").GetValue(x) == id);
            return item.GetType().GetProperty("Name").GetValue(item).ToString();
        }

        private IEnumerable<TContent> GetItems<TContent>(Dictionary<string, bool> dictionary) where TContent : BaseEntity
        {
            var result = new List<TContent>();
            foreach (var item in dictionary)
            {
                if (item.Value)
                {
                    var entity = _db.Set<TContent>().FirstOrDefault(x => x.Name == item.Key);
                    result.Add(entity);
                }
            }
            return result;
        }

        private IEnumerable<TBinder> GetCurrent<TBinder>(int nodeId) where TBinder : class
        {
            var result = _db.Set<TBinder>().Where(x => (int)x.GetType().GetProperty("NodeId").GetValue(x) == nodeId);
            return result;
        }

        private void BindItem<TBinder>(int contentId, int nodeId, TBinder binder) where TBinder : class
        {
            typeof(TBinder)
                .GetProperty("NodeId")
                .SetValue(binder, nodeId);
            typeof(TBinder)
                .GetProperties()
                .FirstOrDefault(x => x.Name.Contains("Id") && !x.Name.Contains("Node"))
                .SetValue(binder, contentId);
            _db.Set<TBinder>().Add(binder);
        }

        // TODO it needs to be tested
        private void UnbindItem<TBinder>(object contentId, object nodeId) where TBinder : class
        {
            var element = _db.Set<TBinder>()
                .FirstOrDefault(x => x.GetType()
                .GetProperty("NodeId")
                .GetValue(x) == nodeId && x.GetType()
                .GetProperties()
                .FirstOrDefault(y => y.Name.Contains("Id") && !y.Name.Contains("Node"))
                .GetValue(x) == contentId);
            _db.Set<TBinder>().Remove(element);
        }
    }
}