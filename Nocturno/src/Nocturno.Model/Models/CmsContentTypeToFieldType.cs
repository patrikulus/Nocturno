using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class CmsContentTypeToFieldType
    {
        public int Id { get; set; }
        public int ContentTypeId { get; set; }
        public int FieldTypeId { get; set; }
    }
}