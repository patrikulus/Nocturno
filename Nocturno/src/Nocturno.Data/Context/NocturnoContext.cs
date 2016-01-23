using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Nocturno.Data.Models;
using System.Security.Cryptography.X509Certificates;

namespace Nocturno.Data.Context
{
    public partial class NocturnoContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        private readonly IConfigurationRoot _config;
        private readonly bool _useInMemory;

        public NocturnoContext()
        {
        }

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
            builder.Entity<ArticleTag>().HasKey(x => new { x.ArticleId, x.TagId });
            builder.Entity<BanerNode>().HasKey(x => new { x.BanerId, x.NodeId });
            builder.Entity<BlogNode>().HasKey(x => new { x.BlogId, x.NodeId });
            builder.Entity<BusinessNode>().HasKey(x => new { x.BusinessId, x.NodeId });
            builder.Entity<PortfolioNode>().HasKey(x => new { x.PortfolioId, x.NodeId });
            builder.Entity<ServiceNode>().HasKey(x => new { x.ServiceId, x.NodeId });
            builder.Entity<SimplePanelNode>().HasKey(x => new { x.SimplePanelId, x.NodeId });
            builder.Entity<SimpleTextNode>().HasKey(x => new { x.SimpleTextId, x.NodeId });
            builder.Entity<SliderNode>().HasKey(x => new { x.SliderId, x.NodeId });

            builder.Entity<ArticleTag>()
                .HasOne(x => x.Article)
                .WithMany(x => x.ArticleTags)
                .HasForeignKey(x => x.ArticleId);

            builder.Entity<ArticleTag>()
                .HasOne(x => x.Tag)
                .WithMany(x => x.ArticleTags)
                .HasForeignKey(x => x.TagId);

            builder.Entity<BanerNode>()
                .HasOne(x => x.Baner)
                .WithMany(x => x.BanerNodes)
                .HasForeignKey(x => x.BanerId);

            builder.Entity<BanerNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.BanerNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<BlogNode>()
                .HasOne(x => x.Blog)
                .WithMany(x => x.BlogNodes)
                .HasForeignKey(x => x.BlogId);

            builder.Entity<BlogNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.BlogNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<BusinessNode>()
                .HasOne(x => x.Business)
                .WithMany(x => x.BusinessNodes)
                .HasForeignKey(x => x.BusinessId);

            builder.Entity<BusinessNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.BusinessNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<PortfolioNode>()
                .HasOne(x => x.Portfolio)
                .WithMany(x => x.PortfolioNodes)
                .HasForeignKey(x => x.PortfolioId);

            builder.Entity<PortfolioNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.PortfolioNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<ServiceNode>()
                .HasOne(x => x.Service)
                .WithMany(x => x.ServiceNodes)
                .HasForeignKey(x => x.ServiceId);

            builder.Entity<ServiceNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.ServiceNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<SimplePanelNode>()
                .HasOne(x => x.SimplePanel)
                .WithMany(x => x.SimplePanelNodes)
                .HasForeignKey(x => x.SimplePanelId);

            builder.Entity<SimplePanelNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.SimplePanelNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<SimpleTextNode>()
                .HasOne(x => x.SimpleText)
                .WithMany(x => x.SimpleTextNodes)
                .HasForeignKey(x => x.SimpleTextId);

            builder.Entity<SimpleTextNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.SimpleTextNodes)
                .HasForeignKey(x => x.NodeId);

            builder.Entity<SliderNode>()
                .HasOne(x => x.Slider)
                .WithMany(x => x.SliderNodes)
                .HasForeignKey(x => x.SliderId);

            builder.Entity<SliderNode>()
                .HasOne(x => x.Node)
                .WithMany(x => x.SliderNodes)
                .HasForeignKey(x => x.NodeId);

            base.OnModelCreating(builder);
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

        #region DataSets

        public DbSet<Article> Articles { get; set; }
        public DbSet<Baner> Baners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessItem> BusinessItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FileType> FileTypes { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SimpleText> SimpleTexts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<Tag> Tags { get; set; }

        #endregion DataSets
    }
}