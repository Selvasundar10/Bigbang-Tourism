using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bigbang_Tourism.Models
{
    public class Feedbacks
    {
        [Key]
        public int Feedback_Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int User_Id { get; set; }

        [Required]
        public string? FeedbackMessage { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public User?  User { get; set; }
    }
}
