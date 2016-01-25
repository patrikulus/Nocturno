﻿using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class Setting : BaseEntity
    {
        public string Value { get; set; }
        //TODO check if it's needed
        public bool IsMandatory { get; set; }
    }
}