using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MuckScraperMVCApp.Models;
using Bogus;

namespace MuckScraperTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    public class DummyData
    {
        public static void Generate()
        {
            var ArticlesFaker = new Faker<Article>()
                .RuleFor(articleClass => articleClass.ArticleId, faker => Guid.NewGuid())
                .RuleFor(articleClass => articleClass.Title, faker => faker.Lorem.Sentence())
                .RuleFor(articleClass => articleClass.AuthorFirstName, faker => faker.Name.FirstName())
                .RuleFor(articleClass => articleClass.AuthorLastName, faker => faker.Name.LastName());
                

            var articleGenerated = ArticlesFaker.Generate();
            Console.WriteLine($"article id : {articleGenerated.ArticleId} firstname: {articleGenerated.AuthorFirstName} lastname: {articleGenerated.AuthorLastName}");
        }
    }
}
