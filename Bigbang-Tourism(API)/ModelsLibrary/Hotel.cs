using System.ComponentModel.DataAnnotations;

namespace ModelsLibrary
{
    public class Hotel
    {
        [Key]
        public int? Hotel_Id { get; set; }

/*        [Required]
*/        [StringLength(20)]
        public string? Hotel_Name { get; set; }

        /*[Required]*/
        [StringLength(30)]
        public string? Location { get; set; }

        [StringLength(20)]
        public string? Contact_Details { get; set; }

/*        [Required]
*/        [StringLength(500)]
        public string? Description { get; set; }

/*        [Required]
*/        public string? ImageURL { get; set; }

        [Range(0, 5)]
        public double? Rating { get; set; }
    }
}
