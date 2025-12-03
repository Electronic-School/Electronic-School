using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;

namespace SchoolSystem.Controls
{
    public partial class ShowAllStudentsControl : UserControl
    {
        private const string connectionString = "Server=.;Database=SchoolManagementDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true;";

        public ShowAllStudentsControl()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    var students = context.Students
                        .Include(s => s.Location)
                        .ThenInclude(l => l.City)
                        .Include(s => s.Location)
                        .ThenInclude(l => l.Country)
                        .Include(s => s.Parent)
                        .Select(s => new
                        {
                            s.StudentsId,
                            s.FirstName,
                            s.LastName,
                            DateOfBirth = s.DateOfBirth.HasValue ? s.DateOfBirth.Value.ToShortDateString() : "",
                            Location = s.Location.Street + ", " + s.Location.BuildingNo + ", " + s.Location.City.CityName + ", " + s.Location.Country.CountryName,
                            ParentName = s.Parent.FirstName + " " + s.Parent.LastName,
                            s.Parent.PhoneNumber,
                            s.Parent.Email
                        })
                        .ToList();

                    dgvStudents.DataSource = students;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load students:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
