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
        DbSet<Blog> Blogs { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Collection> Collections { get; set; }
        DbSet<CollectionItem> CollectionItems { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<MenuItem> MenuItems { get; set; }
        DbSet<Page> Pages { get; set; }
        DbSet<Portfolio> Portfolios { get; set; }
        DbSet<Setting> Properties { get; set; }
        DbSet<Section> Sections { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<TagToArticle> TagsToArticles { get; set; }
        DbSet<SectionToPage> SectionsToPages { get; set; }
        DbSet<CmsContentType> CmsContentTypes { get; set; }
        DbSet<CmsFieldType> CmsFieldTypes { get; set; }
        DbSet<CmsContentTypeToFieldType> CmsContentTypeToFieldTypes { get; set; }
        DbSet<FileType> FileTypes { get; set; }

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