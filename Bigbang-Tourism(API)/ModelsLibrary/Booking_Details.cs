using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLibrary
{
    public class Booking_Details
    {
        [Key]
        public int Booking_Id { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        public int No_of_persons { get; set; }
        public string? TravelerId { get; set; }
        public string? TravelAgencyId { get; set; }

        public int? TourPackageId { get; set; }
        public decimal? BillingPrice { get; set; }


        public string HotelName { get; set; } = string.Empty;
        public string TransportMode { get; set; } = string.Empty;

   
        public Travel_Agent? Travel_Agent { get; set; }

     
     


        public User? User { get; set; }

        public Tour? Tour { get; set; }

        public Hotel? Hotel { get; set; }
    }
}
