

﻿using System;
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
      
      
      
        public int STUDENTID { get; set; } // Khalid
        public string FIRSTNAME { get; set; } = string.Empty;
        public string LASTNAME { get; set; } = string.Empty;
        public DateOnly DATEOFBIRTH { get; set; }

        public int LOCATIONID { get; set; }
        public Location Location { get; set; }

        public int ParentId { get; set; }
        public Parent parents { get; set; } // Khalid
      
      
      
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
