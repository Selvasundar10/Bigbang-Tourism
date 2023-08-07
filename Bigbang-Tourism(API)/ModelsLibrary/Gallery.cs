using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ModelsLibrary
{
    public class Gallery
    {
        [Key]
        public int? Image_Id { get; set; }

        public string? TravelerId { get; set; }

        [Required]
        public string? ImageURL { get; set; }
        public string? Location { get; set; }

        [ForeignKey("User")]
        [JsonIgnore]
        public string? User_Id { get; set; }
        public User? User { get; set; }
    }
}
