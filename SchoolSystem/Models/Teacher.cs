using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        // Location optional (حتى لا يكسر seeding)
        public int? LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Salary { get; set; }

        [StringLength(100)]
        public string? EducationDegree { get; set; }


        [StringLength(100)]
        public string? TeachingSubject { get; set; }

        public DateTime? StartWorkingDate { get; set; }

        public int? NumberOfVacations { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string? SocialStatus { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
