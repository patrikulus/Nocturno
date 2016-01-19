using Nocturno.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Nocturno.Data.Models
{
    public class File
    {
        public string Name { get; set; }
        public double SizeInKiloBytes { get; set; }
        public string Icon { get; set; }
        public DateTime DateModified { get; set; }
    }
}