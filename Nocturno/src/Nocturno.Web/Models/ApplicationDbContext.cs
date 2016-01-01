﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Nocturno.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Web.Models
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //public DbSet<Article> Articles { get; set; }
        //public DbSet<Section> Sections { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
}