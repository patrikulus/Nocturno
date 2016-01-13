using Nocturno.Data.Models;
using Nocturno.Data.Context;
using Nocturno.Data.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Repo
{
    public class PageSectionRepo : BaseRepo<PageSection>, IPageSectionRepo
    {
        public PageSectionRepo(NocturnoContext context) : base(context)
        {
        }
    }
}