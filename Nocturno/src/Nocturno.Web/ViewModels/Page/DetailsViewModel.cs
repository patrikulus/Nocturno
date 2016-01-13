using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.ViewModels.Page
{
    public class DetailsViewModel
    {
        public Data.Models.Page Page { get; set; }
        public ICollection<Data.Models.Section> Sections { get; set; }
    }
}