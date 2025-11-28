using SchoolManagementSystem.Models;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Location
    {
        public int LOCATIONID { get; set; }// khalid
        public int COUNTRYID { get; set; }
        public int CITYID { get; set; }
        public string STREET { get; set; } = string.Empty;
        public string BUILDINGNO { get; set; } = string.Empty;

        public virtual Country Country { get; set; }
        public virtual City City { get; set; }// khalid
        [Key]
        public int LocationId { get; set; }

        [Required]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public required Country Country { get; set; }

        [Required]
        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public required City City { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")] 
        public required string Street { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar(30)")] 
        public required string BuildingNo { get; set; }

        public ICollection<Parent> Parents { get; set; } = new List<Parent>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
