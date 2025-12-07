using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class StudentGrade
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        public string ExamType { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Mark { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
