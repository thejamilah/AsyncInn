using System.ComponentModel.DataAnnotations;

namespace Async_Inn.Models
{
    public class Amenity
    {
        public int ID { get; set; }
        [Required]
        [StringLength(25,ErrorMessage ="Maximum Character Length of 20")]
        public string Name { get; set; }

        //navigation properties
        public RoomAmenity RoomAmenities { get; set; }
    }
}
