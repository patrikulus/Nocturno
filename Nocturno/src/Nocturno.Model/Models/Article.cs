using Nocturno.Model.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Model.Models
{
    public class Article : BaseContent
    {
        public int CategoryId { get; set; }
        public string Synopsis { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<TagToArticle> Tags { get; set; }
    }
}