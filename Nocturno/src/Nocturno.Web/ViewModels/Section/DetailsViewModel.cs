﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.ViewModels.Section
{
    public class DetailsViewModel
    {
        public Model.Models.Section Section { get; set; }
        public ICollection<Model.Models.Page> Pages { get; set; }
    }
}