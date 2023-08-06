using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLibrary
{
    public class User
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string? User_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string User_Name { get; set; } = string.Empty;




        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; } = string.Empty;




        public byte[]? Password { get; set; }
        public byte[]? HashKey { get; set; }
    }
}
