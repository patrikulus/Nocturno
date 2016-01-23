using Nocturno.Data.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Data.Models
{
    public class Article : BaseContent
    {
        public string Synopsis { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ArticleTag> ArticleTags { get; set; }
    }
}