using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class DeleteTeacherControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(44, 62, 80);
        private readonly Color DangerColor = Color.FromArgb(192, 57, 43);

        // متغيرات
        private Teacher currentTeacher;
        private bool isTeacherLoaded = false;

        public DeleteTeacherControl()
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
            StyleTextBox(txtTeacherId);
            StyleTextBox(txtFirstName, true);
            StyleTextBox(txtLastName, true);
            StyleTextBox(txtLocation, true);
            StyleTextBox(txtSubject, true);      // بدلاً من Level
            StyleTextBox(txtDegree, true);       // بدلاً من Parent
            StyleTextBox(txtEmail, true);        // حقل إضافي

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
            // الحقول النصية تظل للقراءة فقط دائماً، لكن نتحكم في الزر
            btnDelete.Enabled = enabled;
            btnClear.Enabled = enabled;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTeacherId.Text.Trim(), out int teacherId))
            {
                MessageBox.Show("Please enter a valid numeric Teacher ID.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherId.Focus();
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSearch.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    // جلب بيانات المعلم مع الموقع
                    currentTeacher = context.Teachers
                        .Include(t => t.Location)
                            .ThenInclude(l => l.City)
                        .Include(t => t.Location)
                            .ThenInclude(l => l.Country)
                        .FirstOrDefault(t => t.TeacherId == teacherId);

                    if (currentTeacher == null)
                    {
                        MessageBox.Show($"Teacher with ID {teacherId} not found.",
                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        isTeacherLoaded = false;
                        return;
                    }

                    // تعبئة البيانات في الواجهة
                    txtFirstName.Text = currentTeacher.FirstName ?? "";
                    txtLastName.Text = currentTeacher.LastName ?? "";
                    txtSubject.Text = currentTeacher.TeachingSubject ?? "N/A";
                    txtDegree.Text = currentTeacher.EducationDegree ?? "N/A";
                    txtEmail.Text = currentTeacher.Email ?? "";

                    dtpDob.Value = currentTeacher.DateOfBirth ?? DateTime.Today.AddYears(-25);

                    // معلومات الموقع
                    string locationText = "N/A";
                    if (currentTeacher.Location != null)
                    {
                        locationText = currentTeacher.Location.Street ?? "";
                        if (currentTeacher.Location.City != null)
                            locationText += $", {currentTeacher.Location.City.CityName}";
                    }
                    txtLocation.Text = locationText;

                    // تمكين الحذف
                    SetFormEnabled(true);
                    isTeacherLoaded = true;
                    lblWarning.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher:\n{ex.Message}",
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
            if (!isTeacherLoaded || currentTeacher == null)
            {
                MessageBox.Show("Please search for a teacher first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // تأكيد الحذف
            string msg = $"Are you sure you want to delete this teacher?\n\n" +
                         $"ID: {currentTeacher.TeacherId}\n" +
                         $"Name: {currentTeacher.FirstName} {currentTeacher.LastName}\n" +
                         $"Subject: {currentTeacher.TeachingSubject}\n\n" +
                         $"⚠️ This action cannot be undone!";

            if (MessageBox.Show(msg, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnDelete.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    var teacherToDelete = context.Teachers.Find(currentTeacher.TeacherId);

                    if (teacherToDelete == null)
                    {
                        MessageBox.Show("Teacher no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        context.Teachers.Remove(teacherToDelete);
                        context.SaveChanges();

                        MessageBox.Show("Teacher deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        isTeacherLoaded = false;
                        currentTeacher = null;
                        SetFormEnabled(false);
                        lblWarning.Visible = false;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        // التعامل مع القيود (مثل إذا كان المعلم مرتبطاً بدورات تدريبية)
                        if (dbEx.InnerException?.Message.Contains("FK_") == true ||
                            dbEx.InnerException?.Message.Contains("constraint") == true)
                        {
                            MessageBox.Show("Cannot delete this teacher because they are assigned to Courses or have related records.\n" +
                                          "Please reassign or delete the courses first.",
                                          "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error deleting teacher:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnDelete.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetFormEnabled(false);
            isTeacherLoaded = false;
            currentTeacher = null;
            lblWarning.Visible = false;
        }

        private void ClearForm()
        {
            txtTeacherId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSubject.Clear();
            txtDegree.Clear();
            txtEmail.Clear();
            txtLocation.Clear();
            dtpDob.Value = DateTime.Today.AddYears(-25);
            txtTeacherId.Focus();
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}