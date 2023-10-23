using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data.Configurations
{
    public class ItemSupplierConfiguration : IEntityTypeConfiguration<ItemSupplier>
    {
        public void Configure(EntityTypeBuilder<ItemSupplier> builder)
        {
            builder.ToTable("ItemsSupplier");

            builder.HasNoKey();
        }
    }
}
