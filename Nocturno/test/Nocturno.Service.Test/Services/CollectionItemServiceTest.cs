using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Service.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nocturno.Service.Test.Services
{
    public class CollectionItemServiceTest
    {
        private readonly IDbContext _db;
        private readonly ICollectionItemService _service;

        public CollectionItemServiceTest()
        {
            _db = new NocturnoContext(true);
            _service = new CollectionItemService(_db);
        }

        [Fact]
        public void Create_CreatingCollectionItem_ShouldCreateCollectionItem()
        {
            // Arrange
            var entity = new CollectionItem
            {
                Name = "Test"
            };
            var before = _db.CollectionItems.Count();

            // Act
            _service.Create(entity);
            _service.Commit();

            // Assert
            Assert.Equal(1, _db.CollectionItems.Count() - before);
        }

        [Fact]
        public void Remove_RemovingCollectionItem_ShouldRemoveCollectionItem()
        {
            // Arrange

            var entity = new CollectionItem
            {
                Name = "Test"
            };
            _db.CollectionItems.Add(entity);
            _db.SaveChanges();
            var before = _db.CollectionItems.Count();

            // Act
            _service.Delete(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(1, before - _db.CollectionItems.Count());
        }

        [Fact]
        public void Update_UpdatingCollectionItem_ShouldUpdateCollectionItem()
        {
            // Arrange

            var entity = new CollectionItem
            {
                Name = "Test"
            };
            _db.CollectionItems.Add(entity);
            _db.SaveChanges();
            var before = _db.CollectionItems.Count();

            // Act
            entity = _service.GetAll().FirstOrDefault();
            entity.Name = "Another name";
            _service.Update(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(before, _db.CollectionItems.Count());
            Assert.Equal("Another name", _db.CollectionItems.FirstOrDefault().Name);
        }

        [Fact]
        public void GetAll_GettingAllItems_ShouldReturnAll()
        {
            // Arrange

            var entities = new List<CollectionItem>
            {
                new CollectionItem {Name = "Test"},
                new CollectionItem {Name = "Test2"},
                new CollectionItem {Name = "Test3"}
            };
            _db.CollectionItems.AddRange(entities);
            _db.SaveChanges();
            var before = _db.CollectionItems.Count();

            // Act
            var all = _service.GetAll();

            // Assert
            Assert.Equal(before, all.Count());
        }
    }
}