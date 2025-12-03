using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;

namespace SchoolSystem.Controls
{
    public partial class SearchStudentControl : UserControl
    {
        private const string connectionString = "Server=.;Database=SchoolManagementDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true;";

        public SearchStudentControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    var student = context.Students
                        .Include(s => s.Location)
                        .ThenInclude(l => l.City)
                        .Include(s => s.Location)
                        .ThenInclude(l => l.Country)
                        .Include(s => s.Parent)
                        .FirstOrDefault(s => s.StudentsId == studentId);

                    if (student == null)
                    {
                        MessageBox.Show($"No student found with ID {studentId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        return;
                    }

                    txtFirstName.Text = student.FirstName;
                    txtLastName.Text = student.LastName;
                    txtDOB.Text = student.DateOfBirth.HasValue ? student.DateOfBirth.Value.ToShortDateString() : "";
                    txtLocation.Text = $"{student.Location.Street}, {student.Location.BuildingNo}, {student.Location.City.CityName}, {student.Location.Country.CountryName}";
                    txtParentName.Text = $"{student.Parent.FirstName} {student.Parent.LastName}";
                    txtParentPhone.Text = student.Parent.PhoneNumber;
                    txtParentEmail.Text = student.Parent.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch student data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            txtLocation.Text = "";
            txtParentName.Text = "";
            txtParentPhone.Text = "";
            txtParentEmail.Text = "";
        }
    }
}
