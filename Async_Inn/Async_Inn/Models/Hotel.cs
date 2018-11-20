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
        [StringLength(25, ErrorMessage ="Maximum Character Length 25")]
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Maximum Character Length 30")]
        public string Address { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Maximum Character Length 25")]
        public string City { get; set; }
        [Required]
        [StringLength(2, ErrorMessage = "Maximum Character Length 2")]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }

        //navigation properties

        public ICollection<HotelRoom> HotelRoom { get; set; }
    }
}
