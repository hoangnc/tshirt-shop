using Microsoft.EntityFrameworkCore;
using TShirtShop.Domain.Entities;

namespace TShirtShop.Persistence
{
    public class TShirtShopDbContext : DbContext
    {
        public TShirtShopDbContext(DbContextOptions<TShirtShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Attribute> Attributes { get;set; }
        public DbSet<AttributeValue> AttributeValues { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tax> Taxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TShirtShopDbContext).Assembly);
        }
    }
}
