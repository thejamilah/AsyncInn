using Async_Inn.Data;
using Async_Inn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
   public class HotelService : IHotel
    {
        private HotelDbContext _context;

        public HotelService(HotelDbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteHotel(int ID)
        {
            throw new System.NotImplementedException();
        }

        public async Task <Hotel> GetHotel(int? ID)
        {
            return await _context.Hotel.FirstOrDefaultAsync(x => x.ID == ID);
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return await _context.Hotel.ToListAsync();
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Hotel.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
