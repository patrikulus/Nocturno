using Nocturno.Model.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Model.Models
{
    public class Category : BaseEntity
    {
        //public int ParentId { get; set; }

        //public virtual Category Parent { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}