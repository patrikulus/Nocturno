using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Tag : BaseEntity
    {
        public virtual ICollection<TagToArticle> Articles { get; set; }
    }
}