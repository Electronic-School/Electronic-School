using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        // Location required
        [Required]
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        // Parent required
        [Required]
        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Parent Parent { get; set; }

        // Level required
        [Required]
        public int LevelId { get; set; }

        [ForeignKey("LevelId")]
        public StudentLevel StudentLevel { get; set; }

        public ICollection<StudentGrade> Grades { get; set; } = new List<StudentGrade>();
        public ICollection<StudentCourseEnrollment> StudentEnrollments { get; set; } = new List<StudentCourseEnrollment>();
    }
}
