using HepsiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HepsiProject.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // tüm configuration dosyalarını bul.
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
