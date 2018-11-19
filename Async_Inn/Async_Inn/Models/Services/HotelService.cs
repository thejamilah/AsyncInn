using Async_Inn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
    public class HotelService : IHotel
    {
        public Task CreateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHotel(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hotel>> GetHotel(int? ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hotel>> GetHotels()
        {
            throw new NotImplementedException();
        }

        public Task UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
