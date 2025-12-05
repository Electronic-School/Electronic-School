using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
    public class Curriculum
    {
        [Key]
        public int CurriculumId { get; set; }

        [StringLength(50)]
        public required string Name { get; set; }

        [StringLength(100)]
        public required string Description { get; set; }

        [Required]
        public int LevelId { get; set; }

        [ForeignKey("LevelId")]
        public required StudentLevel StudentLevel { get; set; }

        [Required]
        [StringLength(20)]
        public required string Semester { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
