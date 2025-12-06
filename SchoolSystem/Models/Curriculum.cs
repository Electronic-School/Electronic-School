using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Curriculum
    {
        [Key]
        public int CurriculumId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        // Level FK (مطلوب)
        [Required]
        public int LevelId { get; set; }

        [ForeignKey("LevelId")]
        public StudentLevel StudentLevel { get; set; }

        [StringLength(20)]
        public string Semester { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
