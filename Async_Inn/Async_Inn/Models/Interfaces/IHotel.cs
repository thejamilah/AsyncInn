using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotel
    {
        Task<List<Hotel>> GetHotel(int? ID);

        Task<IEnumerable<Hotel>> GetHotels();

        Task UpdateHotel(Hotel hotel);

        Task DeleteHotel(int ID);

        Task CreateHotel(Hotel hotel);
        

    }
}
