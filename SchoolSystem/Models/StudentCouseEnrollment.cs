using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class StudentCourseEnrollment
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        [StringLength(20)]
        public string Attendance { get; set; }

        [StringLength(50)]
        public string FinalGrade { get; set; }

        //[ForeignKey("StudentId")]
        public Student Student { get; set; }

        //[ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
