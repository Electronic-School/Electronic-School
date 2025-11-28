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
    public class Student
    {
        [Key]
        public int StudentsId { get; set; }

        [StringLength(50)]
        public required string FirstName { get; set; }
        
        [StringLength(50)]
        public required string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public required Location Location { get; set; }

        [Required]
        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public required Parent Parent { get; set; }

        public ICollection<StudentGrade> Grades { get; set; } = new List<StudentGrade>();
        
        public ICollection<StudentCouseEnrollment> CourseEnrollments { get; set; } = new List<StudentCouseEnrollment>();

    }
}
