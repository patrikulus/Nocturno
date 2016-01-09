using Nocturno.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.ViewModels.Page
{
    public class DetailsViewModel
    {
        public Model.Models.Page Page { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}