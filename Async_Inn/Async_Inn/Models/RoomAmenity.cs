﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class RoomAmenity
    {
        
        public int AmenitiesID { get; set; }

        public int RoomID { get; set; }

        //navigation properties
        public ICollection<Amenity> Amenities { get; set; }

        public ICollection<Room> Room { get; set; }
    }
}