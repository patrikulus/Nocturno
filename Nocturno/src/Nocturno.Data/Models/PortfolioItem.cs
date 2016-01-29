using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class PortfolioItem : MinimalContent
    {
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Portfolio")]
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}