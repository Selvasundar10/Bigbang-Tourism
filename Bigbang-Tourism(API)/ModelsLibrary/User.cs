using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bigbang_Tourism.Models
{
    public class User
    {
        public enum UserRole
        {
            Administrator,
            Travel_Agent,
            User
        }

        [Key]
        public int User_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string User_Name { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        public UserRole Role { get; set; }

        public ICollection<Travel_Agent>? TravelAgents { get; set; }
        public ICollection<Tour>? Tours { get; set; }
        public ICollection<Booking_Details>? BookingDetails { get; set; }
        public ICollection<Feedback>? Feedbacks { get; set; }
    }
}
