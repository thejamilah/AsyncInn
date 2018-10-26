using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class RoomAmenities
    {
        [Key]

        public int AmenitiesID { get; set; }

        public int RoomID { get; set; }
    }
}
