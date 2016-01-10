using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Nocturno.Model.Models;

namespace Nocturno.Repository.Context
{
    public partial class NocturnoContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
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
        public virtual DbSet<SectionToPage> SectionsToPages { get; set; }
    }
}