using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShirtShop.Domain.Entities;

namespace TShirtShop.Persistence.Configurations
{
    public class AttributeValueConfiguration : IEntityTypeConfiguration<AttributeValue>
    {
        public void Configure(EntityTypeBuilder<AttributeValue> builder)
        {
            builder.HasKey(e => e.AttributeValueId);

            builder.Property(e => e.AttributeValueId)
                .ValueGeneratedNever();

            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
