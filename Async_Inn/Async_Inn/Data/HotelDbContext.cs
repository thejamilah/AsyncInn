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

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    HotelName = "Async Inn",
                    Address = "2901 3rd Ave #300",
                    City = "Seattle",
                    State = "WA",
                    Zip = 98121
                },
                new Hotel
                {
                    ID = 2,
                    HotelName = "Hotel Babylon",
                    Address = "123 Elm Street",
                    City = "Nightmare",
                    State = "WA",
                    Zip = 98121
                },

                new Hotel
                {
                    ID = 3,
                    HotelName = "Polymorphism Manor",
                    Address = "1000 Shenanigans Lane",
                    City = "Seattle",
                    State = "WA",
                    Zip = 98101
                },
               new Hotel
               {
                   ID = 4,
                   HotelName = "Inheritance Inn",
                   Address = "2000000 Trust Fund St",
                   City = "Medina",
                   State = "WA",
                   Zip = 98039
               },
               new Hotel
               {
                   ID = 5,
                   HotelName = "Object Instance Class Inn",
                   Address = "1 Shadow of the Space Needle",
                   City = "Seattle",
                   State = "WA",
                   Zip = 98101
               }
               );
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "The Million Dollar View",
                    Layout = Layout.TwoBedroom,
                },
                new Room
                {
                    ID = 2,
                    Name = "Freddie's Dreamspace",
                    Layout = Layout.OneBedroom,
                },
                new Room
                {
                    ID = 3,
                    Name = "Mesopotamia Suite",
                    Layout = Layout.OneBedroom,
                },
                new Room
                {
                    ID = 4,
                    Name = "The Four OOPs",
                    Layout = Layout.Studio,
                },
                new Room
                {
                    ID = 5,
                    Name = "All Property Behaviors",
                    Layout = Layout.TwoBedroom,
                },
                new Room
                {
                    ID = 6,
                    Name = "Seattle Skyline",
                    Layout = Layout.OneBedroom,
                }
                );
            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    ID = 1,
                    Name = "Coffee Maker",
                },
                new Amenity
                {
                    ID = 2,
                    Name = "Tea Maker",
                },
                new Amenity
                {
                    ID = 3,
                    Name = "Craft Cocktail Mini Bar",
                },
                new Amenity
                {
                    ID = 4,
                    Name = "Free WiFi",
                },
                new Amenity
                {
                    ID = 5,
                    Name = "Fog Free Mirror",
                }
                );
        }

        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomAmenity> RoomAmenities { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

    }
}
