using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data.Configurations
{
    public class ItemsStoragesConfiguration : IEntityTypeConfiguration<ItemsStorages>
    {
        public void Configure(EntityTypeBuilder<ItemsStorages> builder)
        {
            builder.ToTable("ItemsSupplier");

            builder.HasNoKey();
        }
    }
}
