using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Async_Inn.Models
{
    public class RoomAmenity
    {
        
        public int AmenitiesID { get; set; }
        [Required]
        public int RoomID { get; set; }

        //navigation properties
        public ICollection<Amenity> Amenities { get; set; }

        public ICollection<Room> Room { get; set; }
    }
}
