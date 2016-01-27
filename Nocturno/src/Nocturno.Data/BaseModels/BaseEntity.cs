using System.ComponentModel.DataAnnotations;

namespace Nocturno.Data.BaseModels
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}