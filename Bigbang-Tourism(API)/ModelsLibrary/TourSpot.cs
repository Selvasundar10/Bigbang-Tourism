using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bigbang_Tourism.Models
{
    public class TourSpot
    {
        [Key]
        public int Spot_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string? SpotName { get; set; }

        [Required]
        [StringLength(20)]
        public string? Location { get; set; }

        [StringLength(200)]
        public string? Specialty { get; set; }

        [Required]
        public string? ImageURL { get; set; }

        [ForeignKey("Tour")]
        public int Tour_Id { get; set; }

        public Tour? Tour { get; set; }
    }
}
