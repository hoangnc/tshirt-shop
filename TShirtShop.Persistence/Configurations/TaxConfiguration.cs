using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShirtShop.Domain.Entities;

namespace TShirtShop.Persistence.Configurations
{
    public class TaxConfiguration : IEntityTypeConfiguration<Tax>
    {
        public void Configure(EntityTypeBuilder<Tax> builder)
        {
            builder.HasKey(e => e.TaxId);

            builder.Property(e => e.TaxId)
                .ValueGeneratedNever();

            builder.Property(e => e.Percentage);
            builder.Property(e => e.Type)
                .HasMaxLength(100);

            builder.HasOne(t => t.Orders)
                .WithOne(o=>o.Tax);
        }
    }
}
