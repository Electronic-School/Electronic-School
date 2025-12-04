using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;

namespace SchoolSystem.Controls
{
    public partial class SearchStudentControl : UserControl
    {
        // ألوان مخصصة للتصميم
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185); // أزرق
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color AccentColor = Color.FromArgb(46, 204, 113); // أخضر

        public SearchStudentControl()
        {
            InitializeComponent();
            ApplyModernDesign();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;

            // تصميم زر البحث
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.BackColor = PrimaryColor;
            btnSearch.ForeColor = Color.White;
            btnSearch.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Padding = new Padding(10, 5, 10, 5);

            // تصميم زر المسح
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.FlatAppearance.BorderColor = PrimaryColor;
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = PrimaryColor;
            btnClear.Font = new Font("Segoe UI", 10);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Padding = new Padding(10, 5, 10, 5);

            // تصميم زر التصدير
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.FlatAppearance.BorderSize = 1;
            btnExport.FlatAppearance.BorderColor = AccentColor;
            btnExport.BackColor = Color.White;
            btnExport.ForeColor = AccentColor;
            btnExport.Font = new Font("Segoe UI", 10);
            btnExport.Cursor = Cursors.Hand;
            btnExport.Padding = new Padding(10, 5, 10, 5);

            // تصميم التكست بوكسات للإدخال
            txtStudentID.BackColor = Color.White;
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 10);

            // إضافة ToolTips
            toolTip.SetToolTip(txtStudentID, "Enter student ID number");
            toolTip.SetToolTip(btnSearch, "Search for student by ID");
            toolTip.SetToolTip(btnClear, "Clear all fields");
            toolTip.SetToolTip(btnExport, "Export student information to text file");

            // إخفاء صورة الطالب وعدم استخدامها
            picStudent.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtStudentID.Focus();
                txtStudentID.SelectAll();
                return;
            }

            if (studentId <= 0)
            {
                MessageBox.Show("Student ID must be a positive number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtStudentID.Focus();
                txtStudentID.SelectAll();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSearch.Enabled = false;
                btnClear.Enabled = false;
                btnExport.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    // اختبار الاتصال أولاً
                    if (!context.Database.CanConnect())
                    {
                        MessageBox.Show("Cannot connect to database. Please check your connection.",
                            "Connection Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    var student = context.Students
                        .Include(s => s.Location)
                            .ThenInclude(l => l.City)
                        .Include(s => s.Location)
                            .ThenInclude(l => l.Country)
                        .Include(s => s.Parent)
                        .AsNoTracking()
                        .FirstOrDefault(s => s.StudentsId == studentId);

                    if (student == null)
                    {
                        MessageBox.Show($"No student found with ID: {studentId}",
                            "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearResults();
                        return;
                    }

                    // عرض البيانات في الحقول
                    DisplayStudentData(student);

                    // إظهار لوحة النتائج
                    pnlResults.Visible = true;
                    btnExport.Enabled = true;

                    // تحديث حالة البحث
                    lblStatus.Text = $"Student found: {student.FirstName} {student.LastName} (ID: {student.StudentsId})";
                    lblStatus.ForeColor = AccentColor;

                    // تسجيل في Log
                    LogSearch(studentId, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch student data:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ClearResults();
                LogSearch(studentId, false, ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSearch.Enabled = true;
                btnClear.Enabled = true;
            }
        }

        private void DisplayStudentData(SchoolSystem.Models.Student student)
        {
            // المعلومات الشخصية
            txtFirstName.Text = student.FirstName ?? "N/A";
            txtLastName.Text = student.LastName ?? "N/A";
            txtDOB.Text = student.DateOfBirth.HasValue
                ? student.DateOfBirth.Value.ToString("dd/MM/yyyy")
                : "N/A";

            // معلومات العنوان
            if (student.Location != null)
            {
                txtLocation.Text = $"{student.Location.Street ?? ""}, {student.Location.BuildingNo ?? ""}".Trim(',', ' ');
                txtCity.Text = student.Location.City?.CityName ?? "N/A";
                txtCountry.Text = student.Location.Country?.CountryName ?? "N/A";
            }
            else
            {
                txtLocation.Text = "N/A";
                txtCity.Text = "N/A";
                txtCountry.Text = "N/A";
            }

            // معلومات ولي الأمر
            if (student.Parent != null)
            {
                txtParentName.Text = $"{student.Parent.FirstName ?? ""} {student.Parent.LastName ?? ""}".Trim();
                txtParentPhone.Text = student.Parent.PhoneNumber ?? "N/A";
                txtParentEmail.Text = student.Parent.Email ?? "N/A";

               
            }
            else
            {
                txtParentName.Text = "N/A";
                txtParentPhone.Text = "N/A";
                txtParentEmail.Text = "N/A";
               
            }
        }

        private void ClearResults()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            txtLocation.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtParentName.Text = "";
            txtParentPhone.Text = "";
            txtParentEmail.Text = "";
            

            pnlResults.Visible = false;
            btnExport.Enabled = false;
            lblStatus.Text = "Enter Student ID and click Search";
            lblStatus.ForeColor = Color.White;
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط ومفاتيح التحكم
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
            // تفعيل زر البحث فقط إذا كان هناك إدخال
            btnSearch.Enabled = !string.IsNullOrWhiteSpace(txtStudentID.Text);
        }

        private void LogSearch(int studentId, bool success, string errorMessage = null)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Search for Student ID: {studentId} - " +
                               $"{(success ? "SUCCESS" : "FAILED")}" +
                               $"{(errorMessage != null ? $" - Error: {errorMessage}" : "")}";

            System.Diagnostics.Debug.WriteLine(logMessage);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToTextFile();
        }

        private void ExportToTextFile()
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
                            writer.WriteLine("STUDENT INFORMATION");
                            writer.WriteLine("=".PadRight(50, '='));
                            writer.WriteLine();
                            writer.WriteLine($"Student ID: {txtStudentID.Text}");
                            writer.WriteLine($"Name: {txtFirstName.Text} {txtLastName.Text}");
                            writer.WriteLine($"Date of Birth: {txtDOB.Text}");
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
                            writer.WriteLine($"Exported on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                            writer.WriteLine("=".PadRight(50, '='));
                        }

                        MessageBox.Show("Student information exported successfully!",
                            "Export Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to export file:\n{ex.Message}",
                            "Export Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}