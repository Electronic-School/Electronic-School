using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public  class StudentLevel
    {
        [Key]
        public int LevelId { get; set; }

        [Required]
        [StringLength(50)]
        public required string LevelName { get; set; }

        [Required]
        public int LevelNumber { get; set; } 

        [Required]
        [StringLength(20)]
        public required string Stage { get; set; } // "ابتدائي", "أساسي", "ثانوي"

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public ICollection<Curriculum> Curriculums { get; set; } = new List<Curriculum>();

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
