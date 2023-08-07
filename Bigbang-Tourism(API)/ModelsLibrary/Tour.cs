using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ModelsLibrary
{
    public class Tour
    {
        [Key]
        public int? Tour_Id { get; set; }

        public string? Tour_Image { get; set; }

/*        [Required]
*//*        [StringLength(20)]
*/        public string? Tour_Name { get; set; }

        public string? Tour_Location { get; set; }
        public string? TravelAgencyId { get; set; }


        public string? Duration { get; set; }
/*        [Required]
*/        [Range(0, int.MaxValue, ErrorMessage = "Cost must be a non-negative value.")]
        public decimal? Cost { get; set; }

        public ICollection<Itinerary>? itineraries { get; set; }
        public ICollection<Hotel>? hotel { get; set; }


        public Travel_Agent? Travel_Agent { get; set; }




    }
}
