using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.CPF_CNPJ).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.Phone).HasMaxLength(14);

            builder.HasMany(p => p.Items).WithMany(p => p.Suppliers).UsingEntity(j => j.ToTable("ItemSupplier"));
            
        }
    }
}
