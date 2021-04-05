using Microsoft.EntityFrameworkCore;
using MuckScraperMVCApp.Models;

namespace MuckScraperMVCApp.Data
{
    public class MuckScraperContext : DbContext
    {
        public MuckScraperContext(DbContextOptions<MuckScraperContext> options)
        : base(options) { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}