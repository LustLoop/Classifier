using Microsoft.EntityFrameworkCore;
using Kursach.Models;

namespace Kursach.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Type> Type { get; set; }

    }
}