using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [StringLength(100)]
        public required string Name { get; set; }

        [StringLength(255)]
        public required string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TeacherID { get; set; }

        [ForeignKey("TeacherID")]
        public required Teacher Teacher { get; set; }

        public int? CurriculumId { get; set; }

        [ForeignKey("CurriculumId")]
        public required Curriculum Curriculum { get; set; }

        public ICollection<StudentGrade> Grades { get; set; } = new List<StudentGrade>();
        public ICollection<StudentCouseEnrollment> StudentEnrollments { get; set; } = new List<StudentCouseEnrollment>();

    }
}