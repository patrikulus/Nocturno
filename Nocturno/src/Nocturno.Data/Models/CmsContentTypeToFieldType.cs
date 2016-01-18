using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class CmsContentTypeToFieldType
    {
        public int CmsContentTypeId { get; set; }
        public int CmsFieldTypeId { get; set; }
        public int Order { get; set; }

        public virtual CmsContentType CmsContentType { get; set; }
        public virtual CmsFieldType CmsFieldType { get; set; }
    }
}