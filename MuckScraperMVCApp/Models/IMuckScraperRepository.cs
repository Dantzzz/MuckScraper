using MuckScraperMVCApp.Models;
using System.Linq;

namespace MuckScraperMVCApp
{
    public interface IMuckScraperRepository
    {
        IQueryable<Article> Articles { get; }
        IQueryable<Profile> Profiles { get; }
        IQueryable<User> Users { get; }
    }
}