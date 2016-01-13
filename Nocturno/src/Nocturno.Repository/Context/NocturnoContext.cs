using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Nocturno.Model.Models;

namespace Nocturno.Repository.Context
{
    public partial class NocturnoContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfigurationRoot _config;

        public NocturnoContext()
        {
        }

        public NocturnoContext(IConfigurationRoot config)
        {
            _config = config;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PageSection>().HasKey(x => new { x.SectionId, x.PageId });
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet5-Nocturno.Web-c39e82c0-12eb-4545-b4ae-a0f99b820a74;Trusted_Connection=True;MultipleActiveResultSets=true");
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
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagToArticle> TagsToArticles { get; set; }
        public virtual DbSet<PageSection> SectionsToPages { get; set; }
    }
}