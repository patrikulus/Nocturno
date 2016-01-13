using Nocturno.Data.Context;
using Nocturno.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Nocturno.Service.Test.Services
{
    public class PageServiceTest
    {
        [Fact]
        public void Add_AddingPage_ShouldWork()
        {
            // Arrange
            IDbContext db = new NocturnoContext(true);
            var entity = new Page
            {
                Name = "Test"
            };

            // Act
            db.Pages.Add(entity);
            db.SaveChanges();

            // Assert
            Assert.Equal(1, db.Pages.Count());
            Assert.Equal("Test", db.Pages.FirstOrDefault().Name);
        }
    }
}