using System.ComponentModel.DataAnnotations;

namespace Bigbang_Tourism.Models
{
    public class Gallery
    {
        [Key]
        public int Image_Id { get; set; }

        [Required]
        public string? ImageURL { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
    }
}
