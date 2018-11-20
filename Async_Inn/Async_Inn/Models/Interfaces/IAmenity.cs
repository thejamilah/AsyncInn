using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{

    interface IAmenity
    {
        Task CreateAmenity(Amenity amenity);

        Task UpdateAmenity(Amenity amenity);

        Task DeleteAmenity(int ID);

        Task<List<Amenity>> GetAmenities();

        Task<Amenity> GetAmenity(int? ID);

    }
}
