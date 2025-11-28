using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public  class Activity
    {
        [Key]
        public int ActivityID { get; set; }

        [StringLength(10)]
        public required string ActivityName { get; set; }

        [StringLength(100)]
        public required string Description { get; set; }

        [StringLength(100)]
        public required string Schedule { get; set; }

        [StringLength(100)]
        public required string Location { get; set; }

        public int? SupervisorId { get; set; } 

        [ForeignKey("SupervisorId")]
        public required Employee Supervisor { get; set; }
    }
}
