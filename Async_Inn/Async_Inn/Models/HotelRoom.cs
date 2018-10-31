﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class HotelRoom
    {
        public int HotelID { get; set; }
        [Required]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Required]
        public int RoomID { get; set; }
        [Required]
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Required]
        [Display(Name = "Room Rate")]
        public decimal RoomRate { get; set; }
        [Required]
        [Display(Name = "Pet Friendly")]
        public bool PetFriendly { get; set; }

        //navigation properties
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}
