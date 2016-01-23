using Nocturno.Data.Models;
using System;

namespace Nocturno.Data.BaseModels
{
    public class BaseContent : BaseEntity
    {
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}