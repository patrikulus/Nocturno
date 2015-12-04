using Nocturno.Model.BaseModels;

namespace Nocturno.Model.Models
{
    public class Article : BaseContent
    {
        public virtual Category Category { get; set; }
    }
}