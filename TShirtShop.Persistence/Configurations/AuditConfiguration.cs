using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShirtShop.Domain.Entities;

namespace TShirtShop.Persistence.Configurations
{
    public class AuditConfiguration : IEntityTypeConfiguration<Audit>
    {
        public void Configure(EntityTypeBuilder<Audit> builder)
        {
            builder.HasKey(e => e.AuditId);

            builder.Property(e => e.AuditId)
                .ValueGeneratedNever();

            builder.Property(e => e.Code);
            builder.Property(e => e.Message);           
            builder.Property(e => e.CreatedOn);

            builder.HasOne(a => a.Orders)
                .WithOne(o => o.Audit)
                .HasForeignKey<Audit>(a=>a.OrderId)
                .HasConstraintName("FK_Audit_Orders_OrderId");
        }
    }
}
