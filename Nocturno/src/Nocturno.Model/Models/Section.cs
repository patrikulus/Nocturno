﻿using Nocturno.Model.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Model.Models
{
    public class Section : BaseEntity
    {
        public virtual ICollection<SectionToPage> Pages { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
    }
}