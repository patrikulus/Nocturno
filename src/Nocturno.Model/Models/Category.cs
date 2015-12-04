using Nocturno.Model.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Model.Models
{
    public class Category : BaseEntity
    {
        public virtual ICollection<Article> Articles { get; set; }
    }
}