using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models

    public class Country
    {        
        public int COUNTRYID { get; set; } // khalid
        public string CountryCODE { get; set; } = string.Empty;// khalid

        public string CountryName { get; set; } = string.Empty;// khalid

        [Key]
        public int CountryID { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "nchar(20)")] 
        public required string CountryCode { get; set; } 

        [Required]
        [StringLength(50)]
        public required string CountryName { get; set; }

        public ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
