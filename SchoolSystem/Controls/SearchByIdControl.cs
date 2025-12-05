using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.Controls
{
    public partial class SearchStudentControl : UserControl
    {
        private readonly Color PrimaryColor = Color.FromArgb(44, 62, 80);
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241);
        private readonly Color SuccessColor = Color.FromArgb(39, 174, 96);

        private SchoolDbContext _context;

        public SearchStudentControl()
        {
            InitializeComponent();
            _context = new SchoolDbContext();
            ApplyModernDesign();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;
            pnlHeader.BackColor = PrimaryColor;

            StyleTextBox(txtStudentID);
            StyleTextBox(txtFirstName, true);
            StyleTextBox(txtLastName, true);
            StyleTextBox(txtDOB, true);
            StyleTextBox(txtLevel, true);
            StyleTextBox(txtStage, true);
            StyleTextBox(txtLocation, true);
            StyleTextBox(txtCity, true);
            StyleTextBox(txtCountry, true);
            StyleTextBox(txtParentName, true);
            StyleTextBox(txtParentPhone, true);
            StyleTextBox(txtParentEmail, true);

            // إزالة الحقول المتعلقة بالكورسات
            txtEnrollments.Visible = false;
            lblEnrollments.Visible = false;
            txtGrades.Visible = false;
            lblGrades.Visible = false;

            StyleButton(btnSearch, PrimaryColor);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166));
            StyleButton(btnExport, SuccessColor);
        }

        private void StyleTextBox(TextBox textBox, bool isReadOnly = false, bool isMultiline = false)
        {
            textBox.BackColor = isReadOnly ? Color.FromArgb(245, 245, 245) : Color.White;
            textBox.ForeColor = Color.FromArgb(44, 62, 80);
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.ReadOnly = isReadOnly;
            textBox.Multiline = isMultiline;

            if (isMultiline)
            {
                textBox.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void StyleButton(Button button, Color backColor)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10);
            button.Cursor = Cursors.Hand;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSearch.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    var student = context.Students
                        .Include(s => s.Location)
                            .ThenInclude(l => l.City)
                        .Include(s => s.Location)
                            .ThenInclude(l => l.Country)
                        .Include(s => s.Parent)
                        .Include(s => s.StudentLevel)  // المستوى الدراسي فقط
                        .AsNoTracking()
                        .FirstOrDefault(s => s.StudentsId == studentId);

                    if (student == null)
                    {
                        MessageBox.Show($"No student found with ID: {studentId}",
                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearResults();
                        return;
                    }

                    DisplayStudentData(student);

                    pnlResults.Visible = true;
                    btnExport.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch student data:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearResults();
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSearch.Enabled = true;
            }
        }

        private void DisplayStudentData(Student student)
        {
            txtFirstName.Text = student.FirstName ?? "N/A";
            txtLastName.Text = student.LastName ?? "N/A";
            txtDOB.Text = student.DateOfBirth.HasValue
                ? student.DateOfBirth.Value.ToString("dd/MM/yyyy")
                : "N/A";

            if (student.StudentLevel != null)
            {
                txtLevel.Text = student.StudentLevel.LevelName ?? "N/A";
                txtStage.Text = student.StudentLevel.Stage ?? "N/A";
            }
            else
            {
                txtLevel.Text = "N/A";
                txtStage.Text = "N/A";
            }

            if (student.Location != null)
            {
                txtLocation.Text = student.Location.Street ?? "N/A";
                txtCity.Text = student.Location.City?.CityName ?? "N/A";
                txtCountry.Text = student.Location.Country?.CountryName ?? "N/A";
            }
            else
            {
                txtLocation.Text = "N/A";
                txtCity.Text = "N/A";
                txtCountry.Text = "N/A";
            }

            if (student.Parent != null)
            {
                txtParentName.Text = $"{student.Parent.FirstName} {student.Parent.LastName}";
                txtParentPhone.Text = student.Parent.PhoneNumber ?? "N/A";
                txtParentEmail.Text = student.Parent.Email ?? "N/A";
            }
            else
            {
                txtParentName.Text = "N/A";
                txtParentPhone.Text = "N/A";
                txtParentEmail.Text = "N/A";
            }

            // إزالة جزء الكورسات والدرجات
            txtEnrollments.Text = "Not available";
            txtGrades.Text = "Not available";
        }

        private void ClearResults()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDOB.Clear();
            txtLevel.Clear();
            txtStage.Clear();
            txtLocation.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtParentName.Clear();
            txtParentPhone.Clear();
            txtParentEmail.Clear();
            txtEnrollments.Clear();
            txtGrades.Clear();

            pnlResults.Visible = false;
            btnExport.Enabled = false;
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            ClearResults();
            txtStudentID.Focus();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = !string.IsNullOrWhiteSpace(txtStudentID.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!pnlResults.Visible) return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Student Information";
                saveFileDialog.FileName = $"Student_{txtStudentID.Text}_{DateTime.Now:yyyyMMdd}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine("=".PadRight(50, '='));
                            writer.WriteLine("STUDENT DETAILED INFORMATION");
                            writer.WriteLine("=".PadRight(50, '='));
                            writer.WriteLine();

                            writer.WriteLine($"Student ID: {txtStudentID.Text}");
                            writer.WriteLine($"Name: {txtFirstName.Text} {txtLastName.Text}");
                            writer.WriteLine($"Date of Birth: {txtDOB.Text}");
                            writer.WriteLine($"Academic Level: {txtLevel.Text} ({txtStage.Text})");
                            writer.WriteLine();

                            writer.WriteLine("Address Information:");
                            writer.WriteLine($"  Location: {txtLocation.Text}");
                            writer.WriteLine($"  City: {txtCity.Text}");
                            writer.WriteLine($"  Country: {txtCountry.Text}");
                            writer.WriteLine();

                            writer.WriteLine("Parent Information:");
                            writer.WriteLine($"  Name: {txtParentName.Text}");
                            writer.WriteLine($"  Phone: {txtParentPhone.Text}");
                            writer.WriteLine($"  Email: {txtParentEmail.Text}");
                            writer.WriteLine();

                            // إزالة قسم الكورسات والدرجات من التصدير
                            writer.WriteLine($"Exported on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                            writer.WriteLine("=".PadRight(50, '='));
                        }

                        MessageBox.Show("Student information exported successfully!",
                            "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to export file:\n{ex.Message}",
                            "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {

        }
    }
}