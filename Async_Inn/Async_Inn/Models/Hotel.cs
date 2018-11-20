using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }

        //navigation properties

        public ICollection<HotelRoom> HotelRoom { get; set; }
    }
}
