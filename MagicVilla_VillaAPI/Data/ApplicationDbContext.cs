using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {      
        }
        public DbSet<Villa> VillaTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This is a detailed description of the Royal Villa.",
                    Rate = 200.00,
                    Sqft = 500,
                    Occupancy = 4,
                    ImageUrl = "https://example.com/royal-villa.jpg",
                    Amenity = "Pool, WiFi, Breakfast",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Luxury Villa",
                    Details = "This is a detailed description of the Luxury Villa.",
                    Rate = 300.00,
                    Sqft = 600,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/luxury-villa.jpg",
                    Amenity = "Spa, Gym, WiFi",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }

    }
}
