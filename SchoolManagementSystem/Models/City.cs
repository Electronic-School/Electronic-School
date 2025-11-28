using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public class City
    {
        public int CITYID { get; set; }
        public string CITYCODE { get; set; } = string.Empty;
        public string CITYNAME { get; set; } = string.Empty;

        public ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
