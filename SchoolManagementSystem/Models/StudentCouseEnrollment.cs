using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class StudentCouseEnrollment
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        [StringLength(20)]
        public required string Attendance { get; set; }

        [StringLength(50)]
        public required string FinalGrade { get; set; }

        [ForeignKey("StudentId")]
        public required Student Student { get; set; }

        [ForeignKey("CourseId")]
        public required Course Course { get; set; }
    }
}
