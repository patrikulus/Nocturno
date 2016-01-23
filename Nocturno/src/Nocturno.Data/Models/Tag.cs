﻿using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Tag : BaseEntity
    {
        public ICollection<ArticleTag> ArticleTags { get; set; }
    }
}