using Nocturno.Model.Models;
using Nocturno.Repository.Context;
using Nocturno.Repository.Repo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nocturno.Repository.Test.Repo
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
            var page = repo.GetAll().FirstOrDefault(x => x.Name == "Home");
            var section = context.Sections.FirstOrDefault(x => x.Name == "Menu");
            repo.AddSectionToPage(section, page);
        }
    }
}