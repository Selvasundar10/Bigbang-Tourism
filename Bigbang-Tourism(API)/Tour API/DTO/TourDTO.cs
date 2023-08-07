using System.ComponentModel.DataAnnotations;

namespace Tour_API.DTO
{
    public class TourDTO
    {
      public string? Tour_Name { get; set; }

        public string? Tour_Location { get; set; }

        public string? Duration { get; set; }


        public decimal? Cost { get; set; }

    }
}
