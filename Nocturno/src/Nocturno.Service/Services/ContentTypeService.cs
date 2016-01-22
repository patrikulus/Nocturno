using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Service.Services
{
    public class ContentTypeService : BaseService<CmsContentType>, IContentTypeService
    {
        public ContentTypeService(IDbContext db) : base(db)
        {
        }

        public void AddField(CmsContentType contentType, CmsFieldType field, int order)
        {
            _db.CmsContentTypeToFieldTypes.Add(new CmsContentTypeToFieldType
            {
                CmsContentTypeId = contentType.Id,
                CmsFieldTypeId = field.Id,
                Order = order
            });
        }

        public void RemoveField(CmsContentType contentType, CmsFieldType field)
        {
            var record = _db.CmsContentTypeToFieldTypes
                .FirstOrDefault(x => x.CmsContentTypeId == contentType.Id && x.CmsFieldTypeId == field.Id);
            _db.CmsContentTypeToFieldTypes.Remove(record);
        }
    }
}