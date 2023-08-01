using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bigbang_Tourism.Models
{
    public enum AgentStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class Travel_Agent
    {
        [Key]
        public int Agent_Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int User_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Agency_Name { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact_Number must be a 10-digit number.")]
        public int Contact_Number { get; set; }

        [Required]
        public AgentStatus Status { get; set; } = AgentStatus.Pending;

        public User? User { get; set; }
    }
}
