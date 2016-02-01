using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Service.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nocturno.Service.Test.Services
{
    public class SectionServiceTest
    {
        private readonly IDbContext _db;
        private readonly ISectionService _service;

        public SectionServiceTest()
        {
            _db = new NocturnoContext(true);
            _service = new SectionService(_db);
        }

        [Fact]
        public void Create_CreatingSection_ShouldCreateSection()
        {
            // Arrange
            var entity = new Section
            {
                Name = "Test"
            };
            var before = _db.Sections.Count();

            // Act
            _service.Create(entity);
            _service.Commit();

            // Assert
            Assert.Equal(1, _db.Sections.Count() - before);
        }

        [Fact]
        public void Remove_RemovingSection_ShouldRemoveSection()
        {
            // Arrange

            var entity = new Section
            {
                Name = "Test"
            };
            _db.Sections.Add(entity);
            _db.SaveChanges();
            var before = _db.Sections.Count();

            // Act
            _service.Delete(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(1, before - _db.Sections.Count());
        }

        [Fact]
        public void Update_UpdatingSection_ShouldUpdateSection()
        {
            // Arrange

            var entity = new Section
            {
                Name = "Test"
            };
            _db.Sections.Add(entity);
            _db.SaveChanges();
            var before = _db.Sections.Count();

            // Act
            entity = _service.GetAll().FirstOrDefault();
            entity.Name = "Another name";
            _service.Update(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(before, _db.Sections.Count());
            Assert.Equal("Another name", _db.Sections.FirstOrDefault().Name);
        }

        [Fact]
        public void GetAll_GettingAllItems_ShouldReturnAll()
        {
            // Arrange

            var entities = new List<Section>
            {
                new Section {Name = "Test"},
                new Section {Name = "Test2"},
                new Section {Name = "Test3"}
            };
            _db.Sections.AddRange(entities);
            _db.SaveChanges();
            var before = _db.Sections.Count();

            // Act
            var all = _service.GetAll();

            // Assert
            Assert.Equal(before, all.Count());
        }
    }
}