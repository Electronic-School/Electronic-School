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
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public required string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public required Location Location { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Salary { get; set; }

        [StringLength(100)]
        public required string EducationDegree { get; set; }

        [StringLength(100)]
        public required string TeachingSubject { get; set; }

        public DateTime? StartWorkingDate { get; set; }

        public int? NumberOfVacations { get; set; }

        [StringLength(15)]
        public required string PhoneNumber { get; set; }

        [StringLength(100)]
        public required string Email { get; set; }

        [StringLength(50)]
        public required string SocialStatus { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
