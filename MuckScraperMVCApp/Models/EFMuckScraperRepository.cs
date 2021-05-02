using MuckScraperMVCApp.Data;
using System.Linq;

namespace MuckScraperMVCApp.Models
{
    public class EFMuckScraperRepository : IArticleRepository
    {
        private MuckScraperContext context;
        public EFMuckScraperRepository(MuckScraperContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Profile> Profiles => context.Profiles;

        public IQueryable<User> Users => context.Users;

        public IQueryable<Article> Articles => context.Articles;
        public int SaveArticle(Article article)
        {
            if (article.ArticleId == 0)
            {
                article.UploadDate = System.DateTime.Now;
                context.Articles.Add(article);
            }
            context.SaveChanges();
            int newArticleId = article.ArticleId;
            return newArticleId;
        }
        public Article GetArticle(int id)
        {
            Article articleRetrieved = context.Articles.Find(id);
            return articleRetrieved;
        }
    }
}