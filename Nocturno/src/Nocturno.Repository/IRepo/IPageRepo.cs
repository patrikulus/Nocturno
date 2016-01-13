using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.IRepo
{
    public interface IPageRepo : IBaseRepo<Page>
    {
        IQueryable<Page> GetAllPagesContainingSection(Section section);

        bool AddSectionToPage(Section section, Page page);
    }
}