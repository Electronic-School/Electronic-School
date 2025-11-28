using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class StudentGrade
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        public required string ExamType { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Mark { get; set; }

        [ForeignKey("StudentId")]
        public required Student Student { get; set; }

        [ForeignKey("CourseId")]
        public required Course Course { get; set; }

    }
}
