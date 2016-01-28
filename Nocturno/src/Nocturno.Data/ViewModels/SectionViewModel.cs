using Nocturno.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nocturno.Data.ViewModels
{
    public class SectionViewModel
    {
        [Display(Name = "Page")]
        public int? PageId { get; set; }

        public IEnumerable<Section> Sections { get; set; }
    }
}