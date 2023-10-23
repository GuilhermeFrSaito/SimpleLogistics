using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleLogistics.Data.Configurations;
using SimpleLogistics.Models;

namespace SimpleLogistics.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private static readonly ILoggerFactory _logger = LoggerFactory.Create(p => p.AddConsole());
        
        // Tables
        public DbSet<Item> Item { get; set; } = default!;

        public DbSet<Supplier> Supplier { get; set; } = default!;

        public DbSet<Sector> Sector { get; set; } = default!;

        public DbSet<Storage> Storage { get; set; } = default!;

        public DbSet<ItemSupplier> ItemSupplier { get; set; } = default!;

        // Constructor?
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseLoggerFactory(_logger)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ItemConfiguration());
            builder.ApplyConfiguration(new SectorConfiguration());
            builder.ApplyConfiguration(new StorageConfiguration());
            builder.ApplyConfiguration(new SupplierConfiguration());
            builder.ApplyConfiguration(new ItemSupplierConfiguration());
            base.OnModelCreating(builder);
        }
    }
}