using Nocturno.Model.Models;
using System;

namespace Nocturno.Model.BaseModels
{
    public class BaseContent : BaseEntity
    {
        public ApplicationUser Author { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}