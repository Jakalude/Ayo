using Microsoft.EntityFrameworkCore;
using Ayo.API.Domain.Models;

namespace Ayo.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<ConversionChart> ConversionCharts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Category
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.ConversionChart).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
            //ConversionChart
            builder.Entity<ConversionChart>().ToTable("ConversionChart");
            builder.Entity<ConversionChart>().HasKey(p => p.Id);
            builder.Entity<ConversionChart>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<ConversionChart>().Property(p => p.Metric).IsRequired().HasMaxLength(25);
            builder.Entity<ConversionChart>().Property(p => p.Imperial).IsRequired().HasMaxLength(25);
        }
    }
}
