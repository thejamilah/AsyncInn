using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Amenity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        //navigation properties
        public ICollection<RoomAmenity> RoomAmenities { get; set; }
    }
}
