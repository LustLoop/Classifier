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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Product>(p => p.Product)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(p => p.ProductId);


            modelBuilder.Entity<ProductCategory>()
                .HasOne<Category>(c => c.Category)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(c => c.CategoryId);

             modelBuilder.Entity<CategoryOption>()
                .HasOne<Category>(c => c.Category)
                .WithMany(c => c.CategoryOptions)
                .HasForeignKey(c => c.CategoryId);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<CategoryOption> CategoryOptions { get; set; }
    }
}