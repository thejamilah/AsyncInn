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
         
        private HotelDbContext _context;

        public AmenityService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenity amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAmenity(int ID)
        {
            Amenity amenity = await GetAmenity(ID);
            _context.Amenities.Remove(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Amenity>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenity> GetAmenity(int? ID)
        {
            return await _context.Amenities.FirstOrDefaultAsync(x => x.ID == ID);
        }

        public async Task UpdateAmenity(Amenity amenity)
        {
            _context.Amenities.Update(amenity);
            await _context.SaveChangesAsync();
        }
    }

}
