using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.ViewModels
{
    public class BusinessViewModel
    {
        public IEnumerable<Business> Businesses { get; set; }
        public IEnumerable<BusinessItem> BusinessItems { get; set; }
    }
}