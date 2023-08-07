using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
    public class Itinerary
    {
        [Key]
        public int? Itinerary_Id { get; set; }


        public int? Days { get; set; }

        public string? Activities { get; set; }

        public Tour? Tour { get; set; }

    }
}
