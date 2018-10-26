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

        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRooms> HotelRooms { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomAmenities> RoomAmenities { get; set; }

        public DbSet<Amenities> Amenities { get; set; }


    }
}
