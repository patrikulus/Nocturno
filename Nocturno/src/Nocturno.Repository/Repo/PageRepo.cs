using Nocturno.Model.Models;
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
            //base.GetAll().Where(p => p.Sections.Contains(section));
            return null;
        }
    }
}