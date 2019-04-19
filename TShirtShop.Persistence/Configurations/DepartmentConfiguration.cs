using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TShirtShop.Domain.Entities;

namespace TShirtShop.Persistence.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(e => e.DepartmentId);

            builder.Property(e => e.DepartmentId)
                .ValueGeneratedNever();

            builder.Property(e => e.Description).HasMaxLength(1000);
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
