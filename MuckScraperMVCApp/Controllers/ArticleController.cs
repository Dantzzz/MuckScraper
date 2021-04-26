using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MuckScraperMVCApp.Models;
using System.Net.Http;
using System.Text.Json;
using MuckScraperMVCApp.Data;

namespace MuckScraperMVCApp.Controllers
{
    public class ArticleController : Controller
    {
        IArticleRepository repository;
        public ArticleController(IArticleRepository repoService)
        {
            repository = repoService;
        }
        public IActionResult Upload()
        {
            return View(new Article());
        }


        [HttpPost]
        public async Task<IActionResult> Upload(Article article)
        {
            ArticleJson retrievedArticle = await GetArticle(article.SourceUrl);

            article.Title = retrievedArticle.title_1;
            if (article.Title != retrievedArticle.title_2) { article.Subtitle = retrievedArticle.title_2; }
            article.AuthorFirstName = retrievedArticle.author;
            article.PublicationName = retrievedArticle.website_url;
            if (retrievedArticle.date_published.HasValue) { article.PublishDate = retrievedArticle.date_published.Value; }
            article.Content = retrievedArticle.content_1;
            article.AddContent = retrievedArticle.content_2;

            if (ModelState.IsValid)
            {
                repository.SaveArticle(article);
                return RedirectToAction("Completed", "Article", article);
            }
            else
            {
                return View();
            }

        }

        public IActionResult Completed(Article article)
        {
            Article createdArticle = repository.GetArticle(article.ArticleId);
            return View(createdArticle);
        }

        public async Task<ArticleJson> GetArticle(string urlString)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(String.Format("https://news-parser1.p.rapidapi.com/article?url={0}", urlString)),
                Headers =
                {
                    { "x-rapidapi-key", "70952da06amsh21fd2b056a6fd6dp1439c7jsn56b7c3d247b0" },
                    { "x-rapidapi-host", "news-parser1.p.rapidapi.com" },
                },
            };
            ArticleJson articleJson = new ArticleJson();
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                articleJson = JsonSerializer.Deserialize<ArticleJson>(body);
            }
            return articleJson;
        }
    }
}
