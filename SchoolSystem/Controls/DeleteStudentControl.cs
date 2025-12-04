using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolSystem.Controls
{
    public partial class DeleteStudentControl : UserControl
    {
        // ألوان التصميم (محدثة)
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185); // أزرق داكن
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color DangerColor = Color.FromArgb(231, 76, 60); // أحمر
        private readonly Color WarningColor = Color.FromArgb(230, 126, 34); // برتقالي
        private readonly Color SuccessColor = Color.FromArgb(46, 204, 113); // أخضر

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

            // تصميم حقول الإدخال
            StyleTextBox(txtStudentId);
            StyleTextBox(txtFirstName, true);
            StyleTextBox(txtLastName, true);
            StyleTextBox(txtLocation, true);
            StyleTextBox(txtParent, true);

            // تصميم DatePicker
            dtpDob.Font = new Font("Segoe UI", 10);
            dtpDob.CalendarFont = new Font("Segoe UI", 9);
            dtpDob.Enabled = false;

            // تصميم الأزرار
            StyleButton(btnSearch, PrimaryColor); // زر البحث - أزرق داكن
            StyleButton(btnDelete, DangerColor, true); // زر الحذف - أحمر (مميز)
            StyleButton(btnClear, Color.FromArgb(149, 165, 166)); // رمادي

            // إضافة ToolTips
            toolTip.SetToolTip(txtStudentId, "Enter student ID to search");
            toolTip.SetToolTip(btnSearch, "Search for student by ID");
            toolTip.SetToolTip(txtFirstName, "Student's first name (read-only)");
            toolTip.SetToolTip(txtLastName, "Student's last name (read-only)");
            toolTip.SetToolTip(dtpDob, "Student's date of birth (read-only)");
            toolTip.SetToolTip(txtLocation, "Student's location details (read-only)");
            toolTip.SetToolTip(txtParent, "Student's parent details (read-only)");
            toolTip.SetToolTip(btnDelete, "⚠️ Delete student permanently");
            toolTip.SetToolTip(btnClear, "Clear all fields");

            // تعطيل الحقول في البداية
            SetFormEnabled(false);
        }

        private void StyleTextBox(System.Windows.Forms.TextBox textBox, bool isReadOnly = false)
        {
            textBox.BackColor = isReadOnly ? SecondaryColor : Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.ReadOnly = isReadOnly;
        }

        private void StyleButton(System.Windows.Forms.Button button, Color backColor, bool isPrimary = false)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", isPrimary ? 10 : 9, isPrimary ? FontStyle.Bold : FontStyle.Regular);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(10, 5, 10, 5);

            // تأثير hover
            button.MouseEnter += (s, e) => button.BackColor = ControlPaint.Light(backColor, 0.1f);
            button.MouseLeave += (s, e) => button.BackColor = backColor;
        }

        private void InitializeDatePicker()
        {
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.MinDate = new DateTime(1900, 1, 1);
            dtpDob.MaxDate = DateTime.Today;
        }

        private void SetFormEnabled(bool enabled)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
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
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtStudentId.Focus();
                txtStudentId.SelectAll();
                return;
            }

            if (studentId <= 0)
            {
                MessageBox.Show("Student ID must be a positive number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtStudentId.Focus();
                txtStudentId.SelectAll();
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
                        .AsNoTracking() // للقراءة فقط
                        .FirstOrDefault(s => s.StudentsId == studentId);

                    if (currentStudent == null)
                    {
                        MessageBox.Show($"Student with ID {studentId} not found.",
                            "Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        ClearForm();
                        SetFormEnabled(false);
                        isStudentLoaded = false;
                        return;
                    }

                    // تعبئة البيانات في الحقول
                    txtFirstName.Text = currentStudent.FirstName ?? "";
                    txtLastName.Text = currentStudent.LastName ?? "";
                    dtpDob.Value = currentStudent.DateOfBirth ?? DateTime.Today.AddYears(-10);

                    // معلومات الموقع
                    string locationText = "N/A";
                    if (currentStudent.Location != null)
                    {
                        locationText = $"{currentStudent.Location.Street ?? ""} {currentStudent.Location.BuildingNo ?? ""}";
                        if (currentStudent.Location.City != null)
                            locationText += $", {currentStudent.Location.City.CityName}";
                        if (currentStudent.Location.Country != null)
                            locationText += $", {currentStudent.Location.Country.CountryName}";
                    }
                    txtLocation.Text = locationText;

                    // معلومات الأب
                    string parentText = "N/A";
                    if (currentStudent.Parent != null)
                    {
                        parentText = $"{currentStudent.Parent.FirstName ?? ""} {currentStudent.Parent.LastName ?? ""}";
                        if (!string.IsNullOrWhiteSpace(currentStudent.Parent.PhoneNumber))
                            parentText += $" ({currentStudent.Parent.PhoneNumber})";
                    }
                    txtParent.Text = parentText;

                    // تمكين الحقول
                    SetFormEnabled(true);
                    isStudentLoaded = true;

                    // عرض رسالة تحذيرية
                    ShowStatusMessage($"⚠️ Student found. Ready for deletion.", WarningColor);

                    // إظهار إشعار تحذيري
                    lblWarning.Visible = true;
                    lblWarning.Text = "⚠️ Warning: This action cannot be undone!";
                    lblWarning.ForeColor = DangerColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                    "No Student Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string studentName = $"{currentStudent.FirstName} {currentStudent.LastName}";
            string studentId = currentStudent.StudentsId.ToString();

            // تأكيد الحذف مع معلومات مفصلة
            string confirmationMessage = $"⚠️ WARNING: This action cannot be undone!\n\n" +
                                       $"Are you sure you want to delete this student?\n\n" +
                                       $"Student ID: {studentId}\n" +
                                       $"Name: {studentName}\n" +
                                       $"Date of Birth: {(currentStudent.DateOfBirth?.ToString("dd/MM/yyyy") ?? "N/A")}";

            if (MessageBox.Show(confirmationMessage,
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                ShowStatusMessage("Deletion cancelled", Color.FromArgb(149, 165, 166));
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnDelete.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    // إعادة تحميل الطالب للتأكد من وجوده
                    var studentToDelete = context.Students.Find(currentStudent.StudentsId);

                    if (studentToDelete == null)
                    {
                        MessageBox.Show("Student no longer exists in database.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    // التحقق من وجود علاقات قد تمنع الحذف
                    try
                    {
                        // محاولة الحذف
                        context.Students.Remove(studentToDelete);
                        context.SaveChanges();

                        // تسجيل الحذف
                        LogDeletion(studentId, studentName);

                        // عرض رسالة النجاح
                        ShowSuccessMessage(studentId, studentName);

                        // إعادة تعيين النموذج
                        ClearForm();
                        SetFormEnabled(false);
                        isStudentLoaded = false;
                        currentStudent = null;

                        // إخفاء التحذير
                        lblWarning.Visible = false;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        // إذا كان هناك أخطاء بسبب العلاقات (Foreign Key constraints)
                        if (dbEx.InnerException?.Message.Contains("FK_") == true ||
                            dbEx.InnerException?.Message.Contains("constraint") == true)
                        {
                            MessageBox.Show("Cannot delete student because there are related records (grades, enrollments, etc.).\n" +
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
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                ShowStatusMessage("All fields cleared", Color.FromArgb(149, 165, 166));
            }
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtLocation.Clear();
            txtParent.Clear();
            dtpDob.Value = DateTime.Today.AddYears(-10);

            txtStudentId.Focus();
        }

        private void ShowSuccessMessage(string studentId, string studentName)
        {
            string message = $"✅ Student deleted successfully!\n\n" +
                           $"Student ID: {studentId}\n" +
                           $"Name: {studentName}\n" +
                           $"Deleted at: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

            MessageBox.Show(message,
                "Deletion Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private async void ShowStatusMessage(string message, Color color)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
            lblStatus.Visible = true;

            // انتظار 3 ثوان بدون تجميد الواجهة
            await Task.Delay(3000);
            lblStatus.Visible = false;
        }

        private void LogDeletion(string studentId, string studentName)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Student deleted - " +
                               $"ID: {studentId}, Name: {studentName}";

            System.Diagnostics.Debug.WriteLine(logMessage);

            // يمكنك إضافة المزيد من التسجيل هنا
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

        // دالة مساعدة لعرض معلومات عن الطالب
        private void DisplayStudentInfo(Student student)
        {
            if (student == null) return;

            // يمكن إضافة المزيد من التفاصيل هنا
            toolTip.SetToolTip(txtLocation, $"Location ID: {student.LocationId}");
            toolTip.SetToolTip(txtParent, $"Parent ID: {student.ParentId}");
        }
    }
}