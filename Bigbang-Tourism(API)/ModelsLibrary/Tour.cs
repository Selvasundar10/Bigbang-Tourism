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

        [Required]
        [ForeignKey("User")]
        public int User_Id { get; set; }

        public User? User { get; set; }  

        [Required]
        [StringLength(20)]
        public string? Tour_Name { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime Tour_Date { get; set; }

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
