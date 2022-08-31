using Mango.Services.Product.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Models.Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });
            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);
            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Models.Product>().HasData(new Models.Product
            {
                Id = 1,
                Name = "Samos",
                Price = 15,
                Description = "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva",
                ImageUrl = "https://gabimango.blob.core.windows.net/mango/14.jpg",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Models.Product>().HasData(new Models.Product
            {
                Id = 2,
                Name = "Paneer Tikka",
                Price = 16,
                Description = "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva",
                ImageUrl = "https://gabimango.blob.core.windows.net/mango/12.jpg",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Models.Product>().HasData(new Models.Product
            {
                Id = 3,
                Name = "Sweet Pie",
                Price = 17,
                Description = "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva",
                ImageUrl = "https://gabimango.blob.core.windows.net/mango/11.jpg",
                CategoryName = "Desert"
            });

            modelBuilder.Entity<Models.Product>().HasData(new Models.Product
            {
                Id = 4,
                Name = "Pav Bhaji",
                Price = 20,
                Description = "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva",
                ImageUrl = "https://gabimango.blob.core.windows.net/mango/13.jpg",
                CategoryName = "Entree"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
