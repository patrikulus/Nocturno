using Nocturno.Data.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Data.Models
{
    public class Category : BaseEntity
    {
        //public int ParentId { get; set; }

        //public virtual Category Parent { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}