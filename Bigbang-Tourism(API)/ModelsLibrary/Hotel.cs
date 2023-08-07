using System.ComponentModel.DataAnnotations;

namespace ModelsLibrary
{
    public class Hotel
    {
        [Key]
        public int? Hotel_id { get; set; }

       [StringLength(20, MinimumLength = 3)]
        public string? Hotel_name { get; set; }

       

        [StringLength(10, MinimumLength = 3)]
        public string? Contact_details { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string? Location { get; set; }


        [StringLength(500, MinimumLength = 10)]
        public string? Description { get; set; }

        public string? ImageURL { get; set; }

        [Range(0, 5)]
        public double? Rating { get; set; }

        public Tour? Tour { get; set; }

    }
}
