using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;

namespace SchoolSystem.Controls
{
    public partial class UpdateStudentControl : UserControl
    {
        private const string ConnectionString =
            "Server=.;Database=SchoolManagementDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public UpdateStudentControl()
        {
            InitializeComponent();
            LoadLocations();
            LoadParents();
        }

        private SchoolDbContext GetDb()
        {
            var options = new DbContextOptionsBuilder<SchoolDbContext>()
                .UseSqlServer(ConnectionString)
                .Options;
            return new SchoolDbContext(options);
        }

        private void LoadLocations()
        {
            using var db = GetDb();

            var locations = db.Locations
                .Include(l => l.Country)
                .Include(l => l.City)
                .Select(l => new
                {
                    l.LocationId,
                    Display = l.Country.CountryName + " - " + l.City.CityName + " - " + l.Street + " - " + l.BuildingNo
                })
                .ToList();

            cmbLocation.Items.Clear();
            foreach (var loc in locations)
                cmbLocation.Items.Add(new ComboItem(loc.LocationId, loc.Display));
        }

        private void LoadParents()
        {
            using var db = GetDb();

            var parents = db.Parents
                .Select(p => new
                {
                    p.ParentsID,
                    Display = p.FirstName + " " + p.LastName
                })
                .ToList();

            cmbParent.Items.Clear();
            foreach (var p in parents)
                cmbParent.Items.Add(new ComboItem(p.ParentsID, p.Display));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int id))
            {
                MessageBox.Show("Invalid ID");
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

            SelectComboItem(cmbLocation, student.LocationId);
            SelectComboItem(cmbParent, student.ParentId);
        }

        private void SelectComboItem(ComboBox combo, int id)
        {
            foreach (ComboItem item in combo.Items)
            {
                if (item.Id == id)
                {
                    combo.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            var loc = cmbLocation.SelectedItem as ComboItem;
            var parent = cmbParent.SelectedItem as ComboItem;

            if (loc == null || parent == null)
            {
                MessageBox.Show("Please select location and parent.");
                return;
            }

            using var db = GetDb();

            var student = db.Students.FirstOrDefault(s => s.StudentsId == id);
            if (student == null)
            {
                MessageBox.Show("Student not found");
                return;
            }

            student.FirstName = txtFirstName.Text.Trim();
            student.LastName = txtLastName.Text.Trim();
            student.DateOfBirth = dtpDob.Value;
            student.LocationId = loc.Id;
            student.ParentId = parent.Id;

            db.SaveChanges();
            MessageBox.Show("Student updated successfully!");
        }
    }

    public class ComboItem
    {
        public int Id { get; }
        public string Display { get; }

        public ComboItem(int id, string display)
        {
            Id = id;
            Display = display;
        }

        public override string ToString() => Display;
    }
}
