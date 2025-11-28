using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Models
{
    public class Parent
    {
      
        public int ParentId { get; set; } // Khalid

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public DateOnly DateOfBirth { get; set; }

        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int ChildrenInSchool { get; set; } // Khalid
    
      
      
      
      
        [Key]
        public int ParentsID { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")] 
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")] 
        public required string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; } 

        [Required]
        public int LocationId { get; set; } 

        [ForeignKey("LocationId")]
        public required Location Location { get; set; } 

        [StringLength(15)]
        public required string PhoneNumber { get; set; } 

        [StringLength(100)]
        public required string Email { get; set; } 

        public int? ChildrenInSchool { get; set; } 

        public ICollection<Student> Children { get; set; } = new List<Student>();
    }
}
