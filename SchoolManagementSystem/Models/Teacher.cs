using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Salary { get; set; }

        [StringLength(100)]
        public string EducationDegree { get; set; }

        [StringLength(100)]
        public string TeachingSubject { get; set; }

        public DateTime? StartWorkingDate { get; set; }

        public int? NumberOfVacations { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SocialStatus { get; set; }
    }
}