using Nocturno.Model.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Model.Models
{
    public class TagToArticle : BaseEntity
    {
        public int TagId { get; set; }
        public int ArticleId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual Article Article { get; set; }
    }
}