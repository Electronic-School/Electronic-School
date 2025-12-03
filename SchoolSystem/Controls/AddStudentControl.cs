using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using SchoolSystem.Controls;

namespace SchoolSystem.Controls
{
    public partial class AddStudentControl : UserControl
    {
        private int selectedLocationId = 0;
        private int selectedParentId = 0;
        private string connectionString = "Server=.;Database=SchoolManagementDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public AddStudentControl()
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

        private void btnSelectParent_Click(object sender, EventArgs e)
        {
            var parentControl = new ParentAddControl();
            parentControl.ParentCreated += (parentId) =>
            {
                selectedParentId = parentId;
                MessageBox.Show($"Parent selected successfully. ID: {selectedParentId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            Form parentForm = new Form();
            parentForm.Text = "Add / Select Parent";
            parentControl.Dock = DockStyle.Fill;
            parentForm.Controls.Add(parentControl);
            parentForm.Size = new System.Drawing.Size(420, 400);
            parentForm.ShowDialog();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            var parentControl = new ParentAddControl();
            parentControl.ParentCreated += (parentId) =>
            {
                selectedParentId = parentId;
                MessageBox.Show($"Parent added successfully. ID: {selectedParentId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            Form parentForm = new Form();
            parentForm.Text = "Add Parent";
            parentControl.Dock = DockStyle.Fill;
            parentForm.Controls.Add(parentControl);
            parentForm.Size = new System.Drawing.Size(420, 400);
            parentForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            DateTime dob = dtpDateOfBirth.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (selectedLocationId == 0 || selectedParentId == 0)
            {
                MessageBox.Show("Please select location and parent.");
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                        INSERT INTO Students (FirstName, LastName, DateOfBirth, LocationId, ParentId)
                        VALUES (@first, @last, @dob, @loc, @parent);
                        SELECT CAST(SCOPE_IDENTITY() as int);";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@first", firstName);
                        command.Parameters.AddWithValue("@last", lastName);
                        command.Parameters.AddWithValue("@dob", dob);
                        command.Parameters.AddWithValue("@loc", selectedLocationId);
                        command.Parameters.AddWithValue("@parent", selectedParentId);

                        int newId = (int)command.ExecuteScalar();
                        MessageBox.Show($"Student added successfully! ID: {newId}");
                    }
                }

                txtFirstName.Clear();
                txtLastName.Clear();
                dtpDateOfBirth.Value = DateTime.Now;
                selectedLocationId = 0;
                selectedParentId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add student:\n{ex.Message}");
            }
        }
    }
}
