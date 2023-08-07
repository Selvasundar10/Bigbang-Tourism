using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLibrary
{


    public class Travel_Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string? Agent_Id { get; set; }

        public string? Agent_Name { get; set; } = string.Empty;


/*        [Required]
*//*        [StringLength(100)]
*/        public string? Agency_Name { get; set; } = string.Empty;


/*        [Required]
*//*        [RegularExpression(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email Address")]
*/        public string? Email { get; set; } = string.Empty;


/*        [Required]
*//*        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact_Number must be a 10-digit number.")]
*/      
        public int? Contact_Number { get; set; }
/*        [Required]
*//*        [RegularExpression("^(traveler|travel_agent|admin)$", ErrorMessage = "The Role field must be 'traveler', 'travel agent', or 'admin'")]
*/        public string? Role { get; set; } = string.Empty;
        public string? Password { get; set; }

        public string? AgencyImage { get; set; } = string.Empty;

        public string? RequestStatus { get; set; } = string.Empty;

    }
}
