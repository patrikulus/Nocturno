using Nocturno.Data.BaseModels;
using System.Collections.Generic;

namespace Nocturno.Data.Models
{
    public class Section : BaseEntity
    {
        //public int ContentId { get; set; }

        //public virtual Content Content { get; set; }
        public virtual ICollection<SectionToPage> Pages { get; set; }

        //public virtual ICollection<Menu> Menus { get; set; }
        //public virtual ICollection<Blog> Blogs { get; set; }
        //public virtual ICollection<Item> Items { get; set; }
        //public virtual ICollection<Collection> Collections { get; set; }
    }
}