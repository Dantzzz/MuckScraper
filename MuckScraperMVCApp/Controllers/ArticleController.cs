using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MuckScraperMVCApp.Models;

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
        public IActionResult Upload(Article article)
        {
            if (ModelState.IsValid)
            {
                repository.SaveArticle(article);
                return RedirectToPage("/Completed", article);
            }
            else
            {
                return View();
            }
        }

        public ViewResult Completed(Article article)
        {
            return View();
        }
    }
}
