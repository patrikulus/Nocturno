﻿using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Blog : BaseContent
    {
        public virtual ICollection<Article> Articles { get; set; }
    }
}