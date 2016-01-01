using Nocturno.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Templates
{
    public class BasicTemplate
    {
        public Section MainSection { get; set; }

        public BasicTemplate()
        {
            //MainSection = new Section
            //{
            //    Name = "Main",
            //    Width = "100%",
            //    Height = "auto",
            //    PositionX = 0,
            //    PositionY = 0,
            //    PositionZ = 0
            //};
        }
    }
}