using Nocturno.Model.Models;
using System;

namespace Nocturno.Model.BaseModels
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