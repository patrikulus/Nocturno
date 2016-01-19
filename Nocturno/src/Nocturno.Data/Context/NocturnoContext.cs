﻿using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Nocturno.Data.Models;

namespace Nocturno.Data.Context
{
    public partial class NocturnoContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        private readonly IConfigurationRoot _config;
        private readonly bool _useInMemory;

        public NocturnoContext(bool useInMemory = false)
        {
            _useInMemory = useInMemory;
        }

        public NocturnoContext(IConfigurationRoot config)
        {
            _config = config;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SectionToPage>().HasKey(x => new { x.SectionId, x.PageId });
            builder.Entity<CmsContentTypeToFieldType>().HasKey(x => new { x.CmsContentTypeId, x.CmsFieldTypeId });
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_useInMemory)
            {
                optionsBuilder.UseInMemoryDatabase();
            }
            else
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet5-Nocturno.Web-c39e82c0-12eb-4545-b4ae-a0f99b820a74;Trusted_Connection=True;MultipleActiveResultSets=true");
            }

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<CollectionItem> CollectionItems { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Setting> Properties { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagToArticle> TagsToArticles { get; set; }
        public virtual DbSet<SectionToPage> SectionsToPages { get; set; }

        public virtual DbSet<CmsContentType> CmsContentTypes { get; set; }
        public virtual DbSet<CmsFieldType> CmsFieldTypes { get; set; }
        public virtual DbSet<CmsContentTypeToFieldType> CmsContentTypeToFieldTypes { get; set; }

        public virtual DbSet<FileType> FileTypes { get; set; }
    }
}