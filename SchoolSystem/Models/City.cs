using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "nchar(20)")]
        public string CityCode { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        // مجرد قيمة نصية تطابق Country.CountryCode — بدون FK
        [Required]
        [StringLength(20)]
        [Column(TypeName = "nchar(20)")]
        public string CountryCode { get; set; }
    }
}
