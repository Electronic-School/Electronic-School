using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class StudentLevel
    {
        [Key]
        public int LevelId { get; set; }

        [Required]
        [StringLength(100)]
        public string LevelName { get; set; }

        [Required]
        public int LevelNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string Stage { get; set; } // "ابتدائي", "أساسي", "ثانوي"

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Curriculum> Curriculums { get; set; } = new List<Curriculum>();
    }
}
