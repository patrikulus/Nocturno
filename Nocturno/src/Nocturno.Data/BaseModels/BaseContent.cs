using Nocturno.Data.Models;
using System;

namespace Nocturno.Data.BaseModels
{
    public class BaseContent : BaseEntity
    {
        public string AuthorId { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}