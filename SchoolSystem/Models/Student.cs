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

        public int LocationId { get; set; }

        [InverseProperty("Students")]
        public Location Location { get; set; }

        // Parent required
        required
        public int ParentId { get; set; }

        public Parent Parent { get; set; }

        // Level required
        required
        public int LevelId { get; set; }

        public StudentLevel StudentLevel { get; set; }

        public ICollection<StudentGrade> Grades { get; set; } = new List<StudentGrade>();
        public ICollection<StudentCourseEnrollment> StudentEnrollments { get; set; } = new List<StudentCourseEnrollment>();
    }
}
