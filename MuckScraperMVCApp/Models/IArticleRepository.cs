using MuckScraperMVCApp.Models;
using System.Linq;

namespace MuckScraperMVCApp
{
    public interface IArticleRepository
    {
        IQueryable<Article> Articles { get; }
        void SaveArticle(Article article);
        public Article GetArticle(int id);
    }
}