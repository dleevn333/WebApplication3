using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Product>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Category>()
                .HasIndex(p => p.CategoryId)
                .IsUnique();
            modelBuilder.Entity<Models.Category>()
                .Property(p => p.CategoryName)
                .HasMaxLength(255);
        }
            
    }
}
