using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data.Configurations
{
    public class StorageConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder.ToTable("Storage");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            
            builder.HasOne(p => p.Sector).WithOne(p => p.Storage).HasForeignKey<Sector>(p => p.Id).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.Items).WithMany(p => p.Storages);

            builder.HasData(
                new Storage { Id = 1, Name = "AdministrativeStorage", SectorId = 1}
            );
            
        }
    }
}
