using Nocturno.Model.BaseModels;

namespace Nocturno.Model.Models
{
    public class Section : BaseEntity
    {
        public int PageId { get; set; }

        public virtual Page Page { get; set; }
    }
}