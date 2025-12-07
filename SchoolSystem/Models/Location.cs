using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Location
    {
        [Key]
        public int LocationId {get; set; }

        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }
        
        //required
        public int CityId { get; set; }
        public City City { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Street { get; set; }

        [StringLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string BuildingNo { get; set; }

        
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Parent> Parents { get; set; } = new List<Parent>();
    }
}
