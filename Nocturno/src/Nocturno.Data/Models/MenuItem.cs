using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class MenuItem : BaseEntity
    {
        [Required]
        public string Hyperlink { get; set; }
        [Required]
        public int Order { get; set; }

        [Required]
        [Display(Name="Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}