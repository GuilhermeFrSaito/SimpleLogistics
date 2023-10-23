using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Item");
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Name).HasColumnType("VARCHAR(80)").IsRequired();
        builder.Property(p => p.Description).HasColumnType("VARCHAR(512)");
        builder.Property(p => p.Brand).HasMaxLength(50);
        builder.Property(p => p.Model).HasMaxLength(50);

        builder.Property(p => p.SupplierId).IsRequired();
        builder.Property(p => p.StorageId).IsRequired();

        builder.HasMany(p => p.Suppliers).WithMany(p => p.Items).UsingEntity(j => j.ToTable("ItemSupplier"));
        builder.HasMany(p => p.Storages).WithMany(p => p.Items).UsingEntity(j => j.ToTable("ItemsStorage"));
    }
}