using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
using Nocturno.Data.Models;
using Remotion.Linq.Clauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Nocturno.Data.Context
{
    public interface IDbContext : IDisposable
    {
        DbSet<Article> Articles { get; set; }
        DbSet<Baner> Baners { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<Business> Businesses { get; set; }
        DbSet<BusinessItem> BusinessItems { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<FileType> FileTypes { get; set; }
        DbSet<Icon> Icons { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<MenuItem> MenuItems { get; set; }
        DbSet<Node> Nodes { get; set; }
        DbSet<Page> Pages { get; set; }
        DbSet<Portfolio> Portfolios { get; set; }
        DbSet<PortfolioItem> PortfolioItems { get; set; }
        DbSet<Section> Sections { get; set; }
        DbSet<Collection> Collections { get; set; }
        DbSet<CollectionItem> CollectionItems { get; set; }
        DbSet<Setting> Settings { get; set; }
        DbSet<SimpleText> SimpleTexts { get; set; }
        DbSet<SimplePanel> SimplePanels { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<Tag> Tags { get; set; }

        EntityEntry<TEntity> Add<TEntity>(TEntity entity, GraphBehavior behavior = GraphBehavior.IncludeDependents) where TEntity : class;

        EntityEntry<TEntity> Attach<TEntity>(TEntity entity, GraphBehavior behavior = GraphBehavior.IncludeDependents) where TEntity : class;

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        EntityEntry<TEntity> Update<TEntity>(TEntity entity, GraphBehavior behavior = GraphBehavior.IncludeDependents) where TEntity : class;
    }
}