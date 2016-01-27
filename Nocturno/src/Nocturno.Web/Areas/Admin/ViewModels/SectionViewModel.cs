using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.ViewModels
{
    public class SectionViewModel
    {
        [Display(Name = "Page")]
        public int? PageId { get; set; }

        public IEnumerable<Section> Sections { get; set; }
    }
}