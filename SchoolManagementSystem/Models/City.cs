using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Models
{
    public class City
    {      
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "nchar(20)")] 
        public required string CityCode { get; set; } 

        [Required]
        [StringLength(50)]
        public required string CityName { get; set; }

        public ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
