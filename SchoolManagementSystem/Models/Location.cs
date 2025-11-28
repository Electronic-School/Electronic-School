using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Models
{
    public class Location
    {
        public int LOCATIONID { get; set; }
        public int COUNTRYID { get; set; }
        public int CITYID { get; set; }
        public string STREET { get; set; } = string.Empty;
        public string BUILDINGNO { get; set; } = string.Empty;

        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
    }
}
