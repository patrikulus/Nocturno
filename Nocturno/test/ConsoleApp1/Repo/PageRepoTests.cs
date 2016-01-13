using Nocturno.Model.Models;
using Nocturno.Repository.Context;
using Nocturno.Repository.Repo;
using NUnit.Framework;
using System.Linq;

namespace ConsoleApp1.Repo
{
    [TestFixture]
    public class PageRepoTests
    {
        [Test, Ignore("Not implemented yet")]
        public void ShouldReturnAllPagesContainingSpecifiedSection()
        {
            // Arrange
            var sut = new PageRepo(new NocturnoContext());

            // Act
            // TODO implement this test
        }

        [Test]
        public void FooTest()
        {
            var context = new NocturnoContext();
            var repo = new PageRepo(context);
            var page = new Page
            {
                Name = "Test",
            };

            //repo.Add(page);
            //context.SaveChanges();

            var result = repo.GetAll().Where(x => x.Name == "Test");

            Assert.NotNull(result);
            Assert.AreEqual(1, result.Count());
        }
    }
}