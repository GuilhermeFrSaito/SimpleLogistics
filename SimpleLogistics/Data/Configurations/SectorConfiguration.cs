using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data.Configurations
{
    public class SectorConfiguration : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sector");
            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Name, "NameIndex");

            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.StorageId).HasColumnName("Id");
            
            builder.HasOne(p => p.Storage).WithOne(p => p.Sector).OnDelete(DeleteBehavior.Cascade).HasForeignKey("Storage","StorageId");

            // Initial Table Values
            builder.HasData(
                new Sector { Id = 1, Name = "AdministrativeSector", StorageId = 1 }
            );
        }
    }
}
