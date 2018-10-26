using Async_Inn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base
            (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomAmenity>().HasKey(
                ce => new { ce.AmenitiesID, ce.RoomID }
                );

            modelBuilder.Entity<HotelRoom>().HasKey(
    ce => new { ce.HotelID, ce.RoomNumber }
    );
        }

        
        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomAmenity> RoomAmenities { get; set; }

        public DbSet<Amenity> Amenities { get; set; }


    }
}
