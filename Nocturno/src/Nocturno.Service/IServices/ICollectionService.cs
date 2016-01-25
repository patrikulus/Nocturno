using Microsoft.AspNet.Mvc.Rendering;
using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface ICollectionService : IBaseService<Collection>
    {
        IEnumerable<string> GetAllCollectionTypes();
    }
}