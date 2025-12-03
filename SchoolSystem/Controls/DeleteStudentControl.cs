using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;

namespace SchoolSystem.Controls
{
    public partial class DeleteStudentControl : UserControl
    {
        private const string ConnectionString =
            "Server=.;Database=SchoolManagementDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public DeleteStudentControl()
        {
            InitializeComponent();
        }

        private SchoolDbContext GetDb()
        {
            var options = new DbContextOptionsBuilder<SchoolDbContext>()
                .UseSqlServer(ConnectionString)
                .Options;
            return new SchoolDbContext(options);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int id))
            {
                MessageBox.Show("Enter a valid student ID");
                return;
            }

            using var db = GetDb();

            var student = db.Students
                .Include(s => s.Location)
                    .ThenInclude(l => l.Country)
                .Include(s => s.Location)
                    .ThenInclude(l => l.City)
                .Include(s => s.Parent)
                .FirstOrDefault(s => s.StudentsId == id);

            if (student == null)
            {
                MessageBox.Show("Student not found");
                return;
            }

            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            dtpDob.Value = student.DateOfBirth ?? DateTime.Now;

            txtLocation.Text = $"{student.Location.Country.CountryName} - {student.Location.City.CityName} - {student.Location.Street} - {student.Location.BuildingNo}";
            txtParent.Text = $"{student.Parent.FirstName} {student.Parent.LastName}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int id))
            {
                MessageBox.Show("Enter a valid student ID");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using var db = GetDb();

            var student = db.Students.FirstOrDefault(s => s.StudentsId == id);

            if (student == null)
            {
                MessageBox.Show("Student not found");
                return;
            }

            db.Students.Remove(student);
            db.SaveChanges();

            MessageBox.Show("Student deleted successfully");

            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtLocation.Clear();
            txtParent.Clear();
            dtpDob.Value = DateTime.Now;
        }
    }
}
