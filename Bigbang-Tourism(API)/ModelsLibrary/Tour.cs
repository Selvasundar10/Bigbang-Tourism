using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bigbang_Tourism.Models
{
    public class Tour
    {
        [Key]
        public int Tour_Id { get; set; }

        [ForeignKey("Travel_Agent")]
    public int Agent_Id { get; set; }

        public Travel_Agent? Travel_Agent { get; set; }


        [Required]
        [StringLength(20)]
        public string? Tour_Name { get; set; }
   

        [Required]
        public string? Itinerary { get; set; }

        public string? Duration { get; set; }    
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Cost must be a non-negative value.")]
        public decimal Cost { get; set; }
        public string? Tour_Location { get; set; }

        [Required]
        [ForeignKey("Hotel")]
        public int Hotel_Id { get; set; }

        public Hotel? Hotel { get; set; }
    }
}
