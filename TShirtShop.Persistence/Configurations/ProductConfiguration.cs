using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShirtShop.Domain.Entities;

namespace TShirtShop.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.ProductId);

            builder.Property(e => e.ProductId)
                .ValueGeneratedNever();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(e => e.Price)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(e => e.DiscountedPrice)
                .HasColumnType("money")
                .HasDefaultValue("((0))")
                .IsRequired();

            builder.Property(e => e.Image)
                .HasMaxLength(150);

            builder.Property(e => e.Image2)
                .HasMaxLength(150);

            builder.Property(e => e.Thumbnail)
                .HasMaxLength(150);

            builder.Property(e => e.Display)
                .IsRequired()
                .HasDefaultValue("((0))");
        }
    }
}
