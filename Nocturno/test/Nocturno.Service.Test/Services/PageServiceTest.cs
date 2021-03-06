﻿using Nocturno.Data.Context;
using Nocturno.Data.Models;
using Nocturno.Service.IServices;
using Nocturno.Service.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nocturno.Service.Test.Services
{
    public class PageServiceTest
    {
        private readonly IDbContext _db;
        private readonly IPageService _service;

        public PageServiceTest()
        {
            _db = new NocturnoContext(true);
            _service = new PageService(_db);
        }

        [Fact]
        public void Create_CreatingPage_ShouldCreatePage()
        {
            // Arrange
            var entity = new Page
            {
                Name = "Test"
            };
            var before = _db.Pages.Count();

            // Act
            _service.Create(entity);
            _service.Commit();

            // Assert
            Assert.Equal(1, _db.Pages.Count() - before);
        }

        [Fact]
        public void Remove_RemovingPage_ShouldRemovePage()
        {
            // Arrange

            var entity = new Page
            {
                Name = "Test"
            };
            _db.Pages.Add(entity);
            _db.SaveChanges();
            var before = _db.Pages.Count();

            // Act
            _service.Delete(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(1, before - _db.Pages.Count());
        }

        [Fact]
        public void Update_UpdatingPage_ShouldUpdatePage()
        {
            // Arrange

            var entity = new Page
            {
                Name = "Test"
            };
            _db.Pages.Add(entity);
            _db.SaveChanges();
            var before = _db.Pages.Count();

            // Act
            entity = _service.GetAll().FirstOrDefault();
            entity.Name = "Another name";
            _service.Update(entity);
            _db.SaveChanges();

            // Assert
            Assert.Equal(before, _db.Pages.Count());
            Assert.Equal("Another name", _db.Pages.FirstOrDefault().Name);
        }

        [Fact]
        public void GetAll_GettingAllItems_ShouldReturnAll()
        {
            // Arrange

            var entities = new List<Page>
            {
                new Page {Name = "Test"},
                new Page {Name = "Test2"},
                new Page {Name = "Test3"}
            };
            _db.Pages.AddRange(entities);
            _db.SaveChanges();
            var before = _db.Pages.Count();

            // Act
            var all = _service.GetAll();

            // Assert
            Assert.Equal(before, all.Count());
        }
    }
}