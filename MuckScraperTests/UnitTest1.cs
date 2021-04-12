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
            int dataCounter = 0;

            var articlesFaker = new Faker<Article>()
                .RuleFor(articleClass => articleClass.ArticleId, faker => Guid.NewGuid())
                .RuleFor(articleClass => articleClass.Title, faker => faker.Lorem.Sentence())
                .RuleFor(articleClass => articleClass.SourceMedium, faker => faker.Lorem.Word())
                .RuleFor(articleClass => articleClass.AuthorFirstName, faker => faker.Name.FirstName())
                .RuleFor(articleClass => articleClass.AuthorLastName, faker => faker.Name.LastName())
                .RuleFor(articleClass => articleClass.SourceUrl, faker => faker.Internet.Url())
                .RuleFor(articleClass => articleClass.PublicationName, faker => faker.Lorem.Word());
                //.RuleFor(articleClass => articleClass.UploadDate, faker => faker.Date.Past(2, null)
                //.RuleFor(articleClass => articleClass.PublishDate, faker => faker.Date.Past(2, null);

            var profilesFaker = new Faker<Profile>()
                .RuleFor(profileClass => profileClass.ProfileId, faker => faker.Random.Number(5000))
                .RuleFor(profileClass => profileClass.UserId, faker => faker.Random.Number(5000))
                .RuleFor(profileClass => profileClass.FirstName, faker => faker.Name.FirstName())
                .RuleFor(profileClass => profileClass.LastName, faker => faker.Name.LastName())
                .RuleFor(profileClass => profileClass.MiddleName, faker => faker.Name.FirstName());
                //.RuleFor(profileClass => profileClass.ProfileId, faker => faker.Image.People());

            var usersFaker = new Faker<User>()
                .RuleFor(userClass => userClass.UserId, faker => faker.Random.Number(5000))
                .RuleFor(userClass => userClass.Username, faker => faker.Internet.UserName())
                .RuleFor(userClass => userClass.Password, faker => faker.Internet.Password())
                //.RuleFor(userClass => userClass.RegistrationDate, faker => faker.Date.Past())
                //.RuleFor(userClass => userClass.LastLoginDate, faker => faker.Date.Past())
                .RuleFor(userClass => userClass.Credentials, faker => faker.Random.Byte())
                .RuleFor(userClass => userClass.PrimaryEmail, faker => faker.Internet.Email());

            while (dataCounter < 51)
            {
                var articleGenerated = articlesFaker.Generate();
                var userGenerated = usersFaker.Generate();
                var profileGenerated = profilesFaker.Generate();
                dataCounter++;
            }

            //Console.WriteLine($"article id : {articleGenerated.ArticleId} firstname: {articleGenerated.AuthorFirstName} lastname: {articleGenerated.AuthorLastName}");
        }
    }
}
