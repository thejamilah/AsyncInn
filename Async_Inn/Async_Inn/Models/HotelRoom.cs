﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class HotelRoom
    {
        public int HotelID { get; set; }

        public int RoomNumber { get; set; }

        public decimal RoomID { get; set; }

        public string RoomName { get; set; }

        public decimal RoomRate { get; set; }

        public bool PetFriendly { get; set; }

        //navigation properties
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}