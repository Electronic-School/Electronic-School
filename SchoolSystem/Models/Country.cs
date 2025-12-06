using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "nchar(20)")]
        public string CountryCode { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

        public ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
