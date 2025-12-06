using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Required]
        public int PersonId { get; set; }

        [StringLength(20)]
        public string PersonType { get; set; } // Student, Teacher, Employee

        [Required]
        public DateTime AttendanceDate { get; set; }

        [StringLength(20)]
        public string AttendanceStatus { get; set; } // Present, Absent, Late, Excused
    }
}
