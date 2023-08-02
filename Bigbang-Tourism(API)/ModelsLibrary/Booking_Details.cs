using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bigbang_Tourism.Models
{
    public class Booking_Details
    {
        [Key]
        public int Booking_Id { get; set; }

        [Required]
        [ForeignKey("Travel_Agent")]
        public int Agent_Id { get; set; }

        [ForeignKey("User")]
        public int? User_Id { get; set; }

        [ForeignKey("Tour")]
        public int? Tour_Id { get; set; }

        [ForeignKey("Hotel")]
        public int? Hotel_Id { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public string? BillingDetails { get; set; }

        [Required]
        [DataType(DataType.Date)]
    

        public int no_of_persons { get; set; }

        [Required]
        public decimal? BillingPrice { get; set; }
        public User? User { get; set; }
        public Tour? Tour { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
