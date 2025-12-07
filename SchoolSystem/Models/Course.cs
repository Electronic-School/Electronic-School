using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // Teacher optional (nullable FK to ease seeding)
        public int? TeacherId { get; set; }

        //[ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        // Curriculum required
        [Required]
        public int CurriculumId { get; set; }

        [ForeignKey("CurriculumId")]
        public Curriculum Curriculum { get; set; }

        public ICollection<StudentGrade> Grades { get; set; } = new List<StudentGrade>();
        public ICollection<StudentCourseEnrollment> StudentEnrollments { get; set; } = new List<StudentCourseEnrollment>();
    }
}
