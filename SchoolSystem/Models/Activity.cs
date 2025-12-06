using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [StringLength(50)]
        public string ActivityName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Schedule { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public int? SupervisorId { get; set; }

        [ForeignKey("SupervisorId")]
        public Employee Supervisor { get; set; }
    }
}
