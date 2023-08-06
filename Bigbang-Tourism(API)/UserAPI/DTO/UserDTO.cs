using System.ComponentModel.DataAnnotations;

namespace UserAPI.DTO
{
    public class UserDTO
    {



        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(20, ErrorMessage = "User Name must be at most 20 characters long.")]
        public string? User_Id { get; set; }

        public string? Token { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public string? Role { get; set; }



    }
}
