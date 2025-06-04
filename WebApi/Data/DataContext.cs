using Microsoft.EntityFrameworkCore;
using WebApi.Data.Entities;

namespace WebApi.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<RestrictionEntity> Restrictions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RestrictionEntity>()
            .HasData(
                new RestrictionEntity { Id = 1, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-1.svg", Description = "Weapons and Dangerous Items" },
                new RestrictionEntity { Id = 2, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-2.svg", Description = "Illegal Substances" },
                new RestrictionEntity { Id = 3, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-3.svg", Description = "Alcohol and Beverages" },
                new RestrictionEntity { Id = 4, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-4.svg", Description = "Recording Equipment" },
                new RestrictionEntity { Id = 5, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-5.svg", Description = "Large or Hazardous Items" },
                new RestrictionEntity { Id = 6, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-6.svg", Description = "Noise Makers and Disruptive Items" },
                new RestrictionEntity { Id = 7, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-7.svg", Description = "Unauthorized Merchandise" },
                new RestrictionEntity { Id = 8, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-8.svg", Description = "Pets and Animals" },
                new RestrictionEntity { Id = 9, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-9.svg", Description = "Bicycles, Skateboards, or Hoverboards" },
                new RestrictionEntity { Id = 10, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-10.svg", Description = "Coolers or Picnic Baskets" },
                new RestrictionEntity { Id = 11, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-11.svg", Description = "Umbrellas or Large Parasols" },
                new RestrictionEntity { Id = 12, ImageUrl = "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-12.svg", Description = "Camping Gear" }
            );
    }
}
