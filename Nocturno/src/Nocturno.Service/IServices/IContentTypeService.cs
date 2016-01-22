using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.IServices
{
    public interface IContentTypeService : IBaseService<CmsContentType>
    {
        void AddField(CmsContentType contentType, CmsFieldType field, int order);

        void RemoveField(CmsContentType contentType, CmsFieldType field);
    }
}