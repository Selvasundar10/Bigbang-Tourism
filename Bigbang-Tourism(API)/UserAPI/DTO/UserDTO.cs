using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bigbang_Tourism.DTOs
{
    public class UserDTO
    {
        public enum UserRole
        {
            Administrator,
            Travel_Agent,
            User
        }


        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(20, ErrorMessage = "User Name must be at most 20 characters long.")]
        public string? User_Name { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public UserRole Role { get; set; }


  
    }
}
