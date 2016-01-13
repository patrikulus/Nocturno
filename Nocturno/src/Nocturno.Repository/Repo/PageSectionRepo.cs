using Nocturno.Data.Models;
using Nocturno.Repository.Context;
using Nocturno.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.Repo
{
    public class PageSectionRepo : BaseRepo<PageSection>, IPageSectionRepo
    {
        public PageSectionRepo(NocturnoContext context) : base(context)
        {
        }
    }
}