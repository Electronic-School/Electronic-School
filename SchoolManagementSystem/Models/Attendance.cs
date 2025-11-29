using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        public required int PersonId { get; set; }
        
        public required DateTime Date { get; set; }

        [StringLength(20)]
        public required string PersonType { get; set; } // CHECK ('Student','Teacher','Emp')

        [Required]
        public required DateTime AttendanceDate { get; set; }

        [StringLength(20)]
        public required string AttendanceStatus { get; set; } // CHECK ('Present', 'Absent', 'Late', 'Excused')


    }
}
