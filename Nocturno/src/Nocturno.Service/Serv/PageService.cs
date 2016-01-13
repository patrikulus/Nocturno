using Nocturno.Data.Models;
using Nocturno.Repository.Common;
using Nocturno.Repository.IRepo;
using Nocturno.Service.IServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Serv
{
    public class PageService : BaseService<Page>, IPageService
    {
        public PageService(IUnitOfWork uow, IBaseRepo<Page> repo) : base(uow, repo)
        {
        }
    }
}