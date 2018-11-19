using Async_Inn.Data;
using Async_Inn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Async_Inn.Models.Services
{
    public class AmenityService : IAmenity
    {
        private HotelDBContext _context;

        public AmenityService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenity amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAmenity(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Amenity>> GetAmenities()
        {
            throw new NotImplementedException();
        }

        public Task<Amenity> GetAmenity(int? ID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAmenity(Amenity amenity)
        {
            throw new NotImplementedException();
        }
    }
}
