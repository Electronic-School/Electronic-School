using SchoolManagementSystem.Models;

    public class Student
    {
        public int STUDENTID { get; set; }
        public string FIRSTNAME { get; set; } = string.Empty;
        public string LASTNAME { get; set; } = string.Empty;
        public DateOnly DATEOFBIRTH { get; set; }

        public int LOCATIONID { get; set; }
        public Location Location { get; set; }

        public int ParentId { get; set; }
        public Parent parents { get; set; }
    }

