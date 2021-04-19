using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MuckScraperMVCApp.Data;
using System;

namespace MuckScraperMVCApp.Models
{
    public class SeedData
    {
        //public static void EnsurePopulated(IApplicationBuilder app)
        //{
        //    MuckScraperContext context = app.ApplicationServices
        //    .CreateScope().ServiceProvider.GetRequiredService<MuckScraperContext>();
        //    if (context.Database.GetPendingMigrations().Any())
        //    {
        //        context.Database.Migrate();
        //    }
        //    if (!context.Articles.Any())
        //    {
        //        context.Articles.AddRange
        //        (
        //            new Article
        //            {
        //                ArticleId = Guid.NewGuid(),
        //                Title = "Is Mac & Cheese Bad For You?",
        //                SourceMedium = "Newspaper",
        //                AuthorFirstName = "Jerry",
        //                AuthorLastName = "Jones",
        //                SourceUrl = "https://www.theblankstreetjournal.com/macncheese",
        //                PublicationName = "The Blank Street Journal",
        //                UploadDate = 
        //                PublishDate =
        //            },
        //            new Article
        //            {
        //                ArticleId = Guid.NewGuid(),
        //                Title = ,
        //                SourceMedium = ,
        //                AuthorFirstName = ,
        //                AuthorLastName = ,
        //                SourceUrl = ,
        //                PublicationName = ,
        //                UploadDate = ,
        //                PublishDate = ,
        //            },
        //            new Article
        //            {
        //                ArticleId = Guid.NewGuid(),
        //                Title = ,
        //                SourceMedium = ,
        //                AuthorFirstName = ,
        //                AuthorLastName = ,
        //                SourceUrl = ,
        //                PublicationName = ,
        //                UploadDate = ,
        //                PublishDate = ,
        //            }
        //        );
        //        context.SaveChanges();
        //    }
        //}
    }
}