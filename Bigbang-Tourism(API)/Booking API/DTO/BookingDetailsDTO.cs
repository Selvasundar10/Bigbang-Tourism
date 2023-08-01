namespace Booking_API.DTO
{
  
        public class BookingDetailsDTO
        {
            public int Booking_Id { get; set; }
            public int Agent_Id { get; set; }
            public int? User_Id { get; set; }
            public int? Tour_Id { get; set; }
            public int? Hotel_Id { get; set; }
            public DateTime BookingDate { get; set; }
            public string? BillingDetails { get; set; }
            public decimal? BillingPrice { get; set; }

        }
}
