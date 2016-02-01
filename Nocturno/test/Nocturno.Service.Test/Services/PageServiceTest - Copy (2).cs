using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Service.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nocturno.Service.Test.Services
{
    public class SimpleTextServiceTest
    {
        private readonly IDbContext _db;
        private readonly ISimpleTextService _service;

        public SimpleTextServiceTest()
        {
            _db = new NocturnoContext(true);
            _service = new SimpleTextService(_db);
        }

        [Fact]
        public void Create_CreatingSimpleText_ShouldCreateSimpleText()
        {
            // Arrange
            var entity = new SimpleText
            {
                Name = "Test"
            };
            var before = _db.SimpleTexts.Count();

            // Act
            _service.Create(entity);
            _service.Commit();

            // Assert
            Assert.Equal(1, _db.SimpleTexts.Count() - before);
        }

        [Fact]
        public void Remove_RemovingSimpleText_ShouldRemoveSimpleText()
        {
            // Arrange

            var entity = new SimpleText
            {
                Name = "Test"
            };
            _db.SimpleTexts.Add(entity);
            _db.SaveChanges();
            var before = _db.SimpleTexts.Count();

            // Act
            _service.Delete(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(1, before - _db.SimpleTexts.Count());
        }

        [Fact]
        public void Update_UpdatingSimpleText_ShouldUpdateSimpleText()
        {
            // Arrange

            var entity = new SimpleText
            {
                Name = "Test"
            };
            _db.SimpleTexts.Add(entity);
            _db.SaveChanges();
            var before = _db.SimpleTexts.Count();

            // Act
            entity = _service.GetAll().FirstOrDefault();
            entity.Name = "Another name";
            _service.Update(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(before, _db.SimpleTexts.Count());
            Assert.Equal("Another name", _db.SimpleTexts.FirstOrDefault().Name);
        }

        [Fact]
        public void GetAll_GettingAllItems_ShouldReturnAll()
        {
            // Arrange

            var entities = new List<SimpleText>
            {
                new SimpleText {Name = "Test"},
                new SimpleText {Name = "Test2"},
                new SimpleText {Name = "Test3"}
            };
            _db.SimpleTexts.AddRange(entities);
            _db.SaveChanges();
            var before = _db.SimpleTexts.Count();

            // Act
            var all = _service.GetAll();

            // Assert
            Assert.Equal(before, all.Count());
        }
    }
}