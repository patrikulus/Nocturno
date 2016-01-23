using Nocturno.Data.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Data.Models
{
    public class Category : BaseEntity
    {
        public string Icon { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}