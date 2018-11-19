using System.ComponentModel.DataAnnotations;

namespace Async_Inn.Models
{
    public class HotelRoom
    {
        public int HotelID { get; set; }
        [Required]
        [Display(Name = "Room Number")]
        [Range(0100, 9999, ErrorMessage = "Room Number Length Exceeded")]
        public int RoomNumber { get; set; }
        [Required]
        public int RoomID { get; set; }
        [Required]
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        [Required(ErrorMessage ="Please enter a valid room pricing structure")]
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
