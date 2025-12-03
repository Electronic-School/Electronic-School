using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.Controls
{
    public partial class ParentAddControl : UserControl
    {
        public event Action<int> ParentCreated;
        private int selectedLocationId = 0;

        public ParentAddControl()
        {
            InitializeComponent();
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            var locationControl = new AddLocationControl();
            locationControl.LocationCreated += (locationId) =>
            {
                selectedLocationId = locationId;
                MessageBox.Show($"Location selected successfully. ID: {selectedLocationId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            Form locationForm = new Form();
            locationForm.Text = "Add / Select Location";
            locationControl.Dock = DockStyle.Fill;
            locationForm.Controls.Add(locationControl);
            locationForm.Size = new System.Drawing.Size(300, 300);
            locationForm.ShowDialog();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime? dob = dtpDateOfBirth.Value;
            int? childrenCount = null;

            if (!string.IsNullOrEmpty(txtChildrenCount.Text))
                childrenCount = int.Parse(txtChildrenCount.Text.Trim());

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedLocationId == 0)
            {
                MessageBox.Show("Please select a location for the parent.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Server=.;Database=SchoolManagementDB;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    var parent = new Parent
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phone,
                        Email = email,
                        DateOfBirth = dob,
                        LocationId = selectedLocationId,
                        Location = context.Locations.Find(selectedLocationId),
                        ChildrenInSchool = childrenCount
                    };

                    context.Parents.Add(parent);
                    context.SaveChanges();

                    MessageBox.Show($"Parent added successfully! ID: {parent.ParentsID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ParentCreated?.Invoke(parent.ParentsID);

                    // Close parent form automatically
                    if (this.Parent is Form parentForm)
                    {
                        parentForm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add parent:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
