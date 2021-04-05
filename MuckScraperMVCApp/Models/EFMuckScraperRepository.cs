using MuckScraperMVCApp.Data;
using System.Linq;

namespace MuckScraperMVCApp.Models
{
    public class EFMuckScraperRepository : IMuckScraperRepository
    {
        private MuckScraperContext context;
        public EFMuckScraperRepository(MuckScraperContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Article> Articles => context.Articles;

        public IQueryable<Profile> Profiles => context.Profiles;

        public IQueryable<User> Users => context.Users;
    }
}