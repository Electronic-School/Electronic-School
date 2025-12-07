using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Parent
    {
        [Key]
        public int ParentId { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public int LocationId { get; set; }

        public Location Location { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? ChildrenInSchool { get; set; }

        public ICollection<Student> Children { get; set; } = new List<Student>();
    }
}
