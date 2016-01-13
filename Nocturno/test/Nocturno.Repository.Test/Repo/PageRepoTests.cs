using Nocturno.Data.Models;
using Nocturno.Repository.Context;
using Nocturno.Repository.Repo;
using System.Linq;
using Xunit;

namespace Nocturno.Repository.Test.Repo
{
    public class PageRepoTests
    {
        [Fact]
        public void ShouldReturnAllPagesContainingSpecifiedSection()
        {
            // Arrange
            var sut = new PageRepo(new NocturnoContext());

            // Act
            // TODO implement this test

            // Assert
        }

        [Fact]
        public void FooTest()
        {
            // Arrange
            var context = new NocturnoContext();
            var repo = new PageRepo(context);
            var page = new Page
            {
                Name = "Test",
            };

            // Act
            repo.Add(page);
            //context.SaveChanges();

            var result = repo.GetAll().Where(x => x.Name == "Test");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Count());
        }
    }
}