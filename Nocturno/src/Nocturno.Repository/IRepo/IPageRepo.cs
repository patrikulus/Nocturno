using Nocturno.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.IRepo
{
    internal interface IPageRepo : IBaseRepo<Page>
    {
        IQueryable<Page> GetAllPagesContainingSection(Section section);
    }
}