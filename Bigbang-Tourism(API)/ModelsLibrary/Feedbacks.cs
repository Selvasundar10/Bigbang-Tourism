using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLibrary
{
    public class Feedbacks
    {
        [Key]
        public int Feedback_Id { get; set; }
        public string? TravelerId { get; set; }




/*        [Required]
*/        public string? FeedbackMessage { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }
  
        public User? User { get; set; }
    }
}
