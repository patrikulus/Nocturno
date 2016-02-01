using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Service.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nocturno.Service.Test.Services
{
    public class CollectionServiceTest
    {
        private readonly IDbContext _db;
        private readonly ICollectionService _service;

        public CollectionServiceTest()
        {
            _db = new NocturnoContext(true);
            _service = new CollectionService(_db);
        }

        [Fact]
        public void Create_CreatingCollection_ShouldCreateCollection()
        {
            // Arrange
            var entity = new Collection
            {
                Name = "Test"
            };
            var before = _db.Collections.Count();

            // Act
            _service.Create(entity);
            _service.Commit();

            // Assert
            Assert.Equal(1, _db.Collections.Count() - before);
        }

        [Fact]
        public void Remove_RemovingCollection_ShouldRemoveCollection()
        {
            // Arrange

            var entity = new Collection
            {
                Name = "Test"
            };
            _db.Collections.Add(entity);
            _db.SaveChanges();
            var before = _db.Collections.Count();

            // Act
            _service.Delete(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(1, before - _db.Collections.Count());
        }

        [Fact]
        public void Update_UpdatingCollection_ShouldUpdateCollection()
        {
            // Arrange

            var entity = new Collection
            {
                Name = "Test"
            };
            _db.Collections.Add(entity);
            _db.SaveChanges();
            var before = _db.Collections.Count();

            // Act
            entity = _service.GetAll().FirstOrDefault();
            entity.Name = "Another name";
            _service.Update(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(before, _db.Collections.Count());
            Assert.Equal("Another name", _db.Collections.FirstOrDefault().Name);
        }

        [Fact]
        public void GetAll_GettingAllItems_ShouldReturnAll()
        {
            // Arrange

            var entities = new List<Collection>
            {
                new Collection {Name = "Test"},
                new Collection {Name = "Test2"},
                new Collection {Name = "Test3"}
            };
            _db.Collections.AddRange(entities);
            _db.SaveChanges();
            var before = _db.Collections.Count();

            // Act
            var all = _service.GetAll();

            // Assert
            Assert.Equal(before, all.Count());
        }
    }
}