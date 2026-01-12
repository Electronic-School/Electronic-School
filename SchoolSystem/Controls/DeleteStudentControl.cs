using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class DeleteStudentControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(44, 62, 80);
        private readonly Color DangerColor = Color.FromArgb(192, 57, 43);

        // متغيرات
        private Student currentStudent;
        private bool isStudentLoaded = false;

        public DeleteStudentControl()
        {
            InitializeComponent();
            ApplyModernDesign();
            InitializeDatePicker();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;
            pnlHeader.BackColor = PrimaryColor;

            // تصميم حقول الإدخال
            StyleTextBox(txtStudentId);
            StyleTextBox(txtFirstName, true);
            StyleTextBox(txtLastName, true);
            StyleTextBox(txtLocation, true);
            StyleTextBox(txtParent, true);
            StyleTextBox(txtStudentLevel, true);

            // تصميم DatePicker
            dtpDob.Font = new Font("Segoe UI", 10);
            dtpDob.Enabled = false;

            // تصميم الأزرار
            StyleButton(btnSearch, PrimaryColor);
            StyleButton(btnDelete, DangerColor, true);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166));

            // تعطيل الحقول في البداية
            SetFormEnabled(false);
        }

        private void StyleTextBox(TextBox textBox, bool isReadOnly = false)
        {
            textBox.BackColor = isReadOnly ? Color.FromArgb(245, 245, 245) : Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.ReadOnly = isReadOnly;
        }

        private void StyleButton(Button button, Color backColor, bool isPrimary = false)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", isPrimary ? 10 : 9, isPrimary ? FontStyle.Bold : FontStyle.Regular);
            button.Cursor = Cursors.Hand;
        }

        private void InitializeDatePicker()
        {
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.MinDate = new DateTime(1950, 1, 1);
            dtpDob.MaxDate = DateTime.Today;
        }

        private void SetFormEnabled(bool enabled)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            txtStudentLevel.Enabled = enabled;
            dtpDob.Enabled = enabled;
            txtLocation.Enabled = enabled;
            txtParent.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnClear.Enabled = enabled;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return;
            }

            if (studentId <= 0)
            {
                MessageBox.Show("Student ID must be a positive number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSearch.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    currentStudent = context.Students
                        .Include(s => s.Location)
                            .ThenInclude(l => l.City)
                        .Include(s => s.Location)
                            .ThenInclude(l => l.Country)
                        .Include(s => s.Parent)
                        .Include(s => s.StudentLevel) 
                        .FirstOrDefault(s => s.StudentId == studentId);

                    if (currentStudent == null)
                    {
                        MessageBox.Show($"Student with ID {studentId} not found.",
                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        SetFormEnabled(false);
                        isStudentLoaded = false;
                        return;
                    }

                    // تعبئة البيانات
                    txtFirstName.Text = currentStudent.FirstName ?? "";
                    txtLastName.Text = currentStudent.LastName ?? "";
                    if (currentStudent.StudentLevel != null)
                    {
                        txtStudentLevel.Text = currentStudent.StudentLevel.LevelName ?? "Not specified";
                    }
                    else
                    {
                        txtStudentLevel.Text = "Not specified";
                    }
                    dtpDob.Value = currentStudent.DateOfBirth ?? DateTime.Today.AddYears(-10);

                    // معلومات الموقع
                    string locationText = "N/A";
                    if (currentStudent.Location != null)
                    {
                        locationText = currentStudent.Location.Street ?? "";
                        if (currentStudent.Location.City != null)
                            locationText += $", {currentStudent.Location.City.CityName}";
                    }
                    txtLocation.Text = locationText;

                    // معلومات الأب
                    string parentText = "N/A";
                    if (currentStudent.Parent != null)
                    {
                        parentText = $"{currentStudent.Parent.FirstName} {currentStudent.Parent.LastName}";
                    }
                    txtParent.Text = parentText;

                    // تمكين الحقول
                    SetFormEnabled(true);
                    isStudentLoaded = true;

                    // إظهار تحذير
                    lblWarning.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSearch.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isStudentLoaded || currentStudent == null)
            {
                MessageBox.Show("Please search for a student first.",
                    "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentName = $"{currentStudent.FirstName} {currentStudent.LastName}";
            string studentId = currentStudent.StudentId.ToString();

            // تأكيد الحذف
            string confirmationMessage = $"Are you sure you want to delete this student?\n\n" +
                                       $"Student ID: {studentId}\n" +
                                       $"Name: {studentName}\n" +
                                       $"Student Level: {currentStudent.StudentLevel}\n" +
                                       $"Date of Birth: {(currentStudent.DateOfBirth?.ToString("dd/MM/yyyy") ?? "N/A")}\n\n" +
                                       $"This action cannot be undone!";

            if (MessageBox.Show(confirmationMessage,
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnDelete.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    // إعادة تحميل الطالب للتأكد من وجوده
                    var studentToDelete = context.Students.Find(currentStudent.StudentId);

                    if (studentToDelete == null)
                    {
                        MessageBox.Show("Student no longer exists in database.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        // محاولة الحذف
                        context.Students.Remove(studentToDelete);
                        context.SaveChanges();

                        // عرض رسالة النجاح
                        string successMessage = $"Student deleted successfully!\n\n" +
                                              $"Student ID: {studentId}\n" +
                                              $"Name: {studentName}\n" +
                                              $"Deleted at: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

                        MessageBox.Show(successMessage,
                            "Deletion Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // إعادة تعيين النموذج
                        ClearForm();
                        SetFormEnabled(false);
                        isStudentLoaded = false;
                        currentStudent = null;
                        lblWarning.Visible = false;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        // إذا كان هناك أخطاء بسبب العلاقات (Foreign Key constraints)
                        if (dbEx.InnerException?.Message.Contains("FK_") == true ||
                            dbEx.InnerException?.Message.Contains("constraint") == true)
                        {
                            MessageBox.Show("Cannot delete student because there are related records.\n" +
                                          "Please delete related records first or contact administrator.",
                                          "Deletion Blocked",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnDelete.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all fields?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearForm();
                SetFormEnabled(false);
                isStudentLoaded = false;
                currentStudent = null;
                lblWarning.Visible = false;
            }
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStudentLevel.Clear();
            txtLocation.Clear();
            txtParent.Clear();
            dtpDob.Value = DateTime.Today.AddYears(-10);

            txtStudentId.Focus();
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}