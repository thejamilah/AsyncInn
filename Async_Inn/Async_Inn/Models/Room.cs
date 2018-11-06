using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Async_Inn.Models
{
    public class Room
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Layout Type")]
        [EnumDataType(typeof(Layout))]
        public Layout Layout { get; set; }

        //navigation properties
        public ICollection<HotelRoom> HotelRoom { get; set; }

        public RoomAmenity RoomAmenity { get; set; }

    }

    public enum Layout
    {
        [Display(Name = "Studio")]
        Studio,
        [Display(Name = "One Bedroom")]
        OneBedroom,
        [Display(Name = "Two Bedroom")]
        TwoBedroom,
    }

}
