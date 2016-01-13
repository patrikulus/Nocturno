using Nocturno.Data.Models;
using Nocturno.Repository.Context;
using Nocturno.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.Repo
{
    public class PageRepo : BaseRepo<Page>, IPageRepo
    {
        public PageRepo(NocturnoContext context) : base(context)
        {
        }

        public IQueryable<Page> GetAllPagesContainingSection(Section section)
        {
            var result = GetAll()
                        .Where(p => p.Sections.Select(x => x.SectionId)
                        .Contains(section.Id));
            return result;
        }

        public bool AddSectionToPage(Section section, Page page)
        {
            // .Add(new PageSection
            //  {
            //      PageId = page.Id,
            //      SectionId = section.Id
            //  });

            return true;
        }
    }
}