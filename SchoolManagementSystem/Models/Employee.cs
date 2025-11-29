using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }        
        [StringLength(50)]
        public required string FirstName { get; set; }

        [StringLength(50)]
        public required string LastName { get; set; }
        
        public DateTime? DateOfBirth { get; set; }

        public required int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public required Location LOcation { get; set; }

        [StringLength(15)]
        public required string PhoneNumber { get; set; }

        [StringLength(100)]
        public required string Email { get; set;  }

        [StringLength(50)]
        public required string JobTitle { get; set; }

        [StringLength(50)]
        public required string Department { get; set; }

        public DateTime? HireDate { get; set; }

        [Column(TypeName ="decimal(10,2")]
        public decimal? Salary { get; set; }

        [StringLength(50)]
        public required string SocialStatus { get; set; }

        public ICollection<Activity> ActivitiesSupervised { get; set; } = new List<Activity>();
    }
}
