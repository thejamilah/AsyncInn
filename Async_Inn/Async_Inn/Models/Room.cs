using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Room
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Layout Layout { get; set; }

        //navigation properties
        public ICollection<HotelRoom> HotelRoom { get; set; }

        public ICollection<RoomAmenity> RoomAmenity { get; set; }

    }

    public enum Layout
    {
        Studio,
        OneBedroom,
        TwoBedroom,
    }

}
