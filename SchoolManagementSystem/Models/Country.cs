using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{public class Country
    {
        public int COUNTRYID { get; set; }
        public string CountryCODE { get; set; } = string.Empty;

        public string CountryName { get; set; } = string.Empty;

        public ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
