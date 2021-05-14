using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using MuckScraperMVCApp.Models;
using System.Net.Http;
using MuckScraperMVCApp.Data;
using System.Text.Json;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MuckScraperMVCApp.Controllers
{
    public class ArticleController : Controller
    {
        private readonly MuckScraperContext _context;
        IArticleRepository repository;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public ArticleController(IArticleRepository repoService, MuckScraperContext context, UserManager<User> user, SignInManager<User> signin)
        {
            repository = repoService;
            _context = context;
            _userManager = user;
            _signInManager = signin;
        }
        public IActionResult Upload()
        {
            return View(new Article());
        }

        [HttpPost]
        public async Task<IActionResult> Upload(Article article)
        {
            ArticleJson retrievedArticle = await GetArticle(article.SourceUrl);

            article.RequestId = Int32.Parse(_userManager.GetUserId(User));
            article.Title = retrievedArticle.title_1;
            if (article.Title != retrievedArticle.title_2) { article.Subtitle = retrievedArticle.title_2; }
            article.AuthorName = retrievedArticle.author;
            article.PublicationName = retrievedArticle.website_url;
            if (retrievedArticle.date_published != null && retrievedArticle.date_published != "") 
            {
                DateTime dateValue;
                if (DateTime.TryParse(retrievedArticle.date_published, out dateValue))
                {
                    article.PublishDate = dateValue;
                }
            }
            article.Content = retrievedArticle.content_1;
            article.AddContent = retrievedArticle.content_2;
            article.Image = retrievedArticle.lead_image_url;

            if (ModelState.IsValid)
            {
                int newArticle = repository.SaveArticle(article);
                return RedirectToAction("Completed", "Article", new { ArticleId = newArticle });
            }
            else
            {
                return View();
            }

        }

        public IActionResult Completed(int ArticleId)
        {
            Article createdArticle = repository.GetArticle(ArticleId);
            return View(createdArticle);
        }
        public async Task<IActionResult> Library()
        {
            
            return View(await repository.Articles.ToListAsync());
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
                //Console.WriteLine(body);

                articleJson = JsonSerializer.Deserialize<ArticleJson>(body);
            }
            return articleJson;
        }

        //GET: UserTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }
            
            return View(article);
        }

        // POST: UserTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return RedirectToAction("Library", "Article");
        }
    }
}
