using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.Controls
{
    public partial class AddStudentControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(52, 152, 219); // أزرق فاتح
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color SuccessColor = Color.FromArgb(46, 204, 113); // أخضر

        // متغيرات للبيانات المحددة
        private int selectedLocationId = 0;
        private int selectedParentId = 0;

        public AddStudentControl()
        {
            InitializeComponent();
            ApplyModernDesign();
            InitializeDatePicker();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;

            // تصميم حقول الإدخال
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10);

            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10);

            // تصميم DatePicker
            dtpDateOfBirth.Font = new Font("Segoe UI", 10);
            dtpDateOfBirth.CalendarFont = new Font("Segoe UI", 9);

            // تصميم الأزرار
            StyleButton(btnAddLocation, PrimaryColor);
            StyleButton(btnAddParent, PrimaryColor);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166)); // رمادي
            StyleButton(btnAddStudent, SuccessColor, true);

            // إضافة ToolTips
            toolTip.SetToolTip(txtFirstName, "Enter student's first name");
            toolTip.SetToolTip(txtLastName, "Enter student's last name");
            toolTip.SetToolTip(dtpDateOfBirth, "Select student's date of birth");
            toolTip.SetToolTip(btnAddLocation, "Add location details");
            toolTip.SetToolTip(btnAddParent, "Add parent details");
            toolTip.SetToolTip(btnAddStudent, "Save new student");
            toolTip.SetToolTip(btnClear, "Clear all fields");
        }

        private void StyleButton(Button button, Color backColor, bool isPrimary = false)
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
            // تعيين الحد الأدنى للتاريخ (مثال: من 1990)
            dtpDateOfBirth.MinDate = new DateTime(1990, 1, 1);
            dtpDateOfBirth.MaxDate = DateTime.Today;
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-10); // قيمة افتراضية: عمر 10 سنوات
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            OpenLocationForm();
        }

        private void OpenLocationForm()
        {
            var locationControl = new AddLocationControl();
            locationControl.LocationCreated += (locationId) =>
            {
                selectedLocationId = locationId;
                ShowStatusMessage($"Location added successfully! ID: {locationId}", SuccessColor);
            };

            Form locationForm = new Form
            {
                Text = "Add Location Details",
                Size = new Size(500, 400),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            locationControl.Dock = DockStyle.Fill;
            locationForm.Controls.Add(locationControl);
            locationForm.ShowDialog();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            OpenParentForm();
        }

        private void OpenParentForm()
        {
            var parentControl = new ParentAddControl();
            parentControl.ParentCreated += (parentId) =>
            {
                selectedParentId = parentId;
                ShowStatusMessage($"Parent added successfully! ID: {parentId}", SuccessColor);
            };

            Form parentForm = new Form
            {
                Text = "Add Parent Details",
                Size = new Size(500, 450),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            parentControl.Dock = DockStyle.Fill;
            parentForm.Controls.Add(parentControl);
            parentForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnAddStudent.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    

                    // جلب الموقع والاب من قاعدة البيانات
                    var location = context.Locations.Find(selectedLocationId);
                    var parent = context.Parents.Find(selectedParentId);

                    if (location == null || parent == null)
                    {
                        MessageBox.Show("Please select a valid location and parent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newStudent = new Student
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        DateOfBirth = dtpDateOfBirth.Value.Date,
                        Location = location,  // مهم: تعيين object وليس Id فقط
                        Parent = parent       // مهم: تعيين object وليس Id فقط
                    };

                    context.Students.Add(newStudent);
                    context.SaveChanges();

                    MessageBox.Show($"Student created successfully! ID: {newStudent.StudentsId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // حفظ في قاعدة البيانات
                    context.Students.Add(newStudent);
                    context.SaveChanges();

                    // عرض رسالة النجاح
                    ShowSuccessMessage(newStudent.StudentsId);

                    // تسجيل في Log
                    LogStudentCreation(newStudent.StudentsId, newStudent.FirstName, newStudent.LastName);

                    // إعادة تعيين النموذج
                    ResetForm();
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add student:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnAddStudent.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            // التحقق من الاسم الأول
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowValidationError(txtFirstName, "First name is required");
                return false;
            }

            if (txtFirstName.Text.Length < 2)
            {
                ShowValidationError(txtFirstName, "First name must be at least 2 characters");
                return false;
            }

            // التحقق من الاسم الأخير
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowValidationError(txtLastName, "Last name is required");
                return false;
            }

            if (txtLastName.Text.Length < 2)
            {
                ShowValidationError(txtLastName, "Last name must be at least 2 characters");
                return false;
            }

            // التحقق من التاريخ
            if (dtpDateOfBirth.Value > DateTime.Today)
            {
                ShowValidationError(dtpDateOfBirth, "Date of birth cannot be in the future");
                return false;
            }

            // التحقق من الموقع
            if (selectedLocationId == 0)
            {
                MessageBox.Show("Please add location details for the student.",
                    "Location Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                btnAddLocation.Focus();
                return false;
            }

            // التحقق من ولي الأمر
            if (selectedParentId == 0)
            {
                MessageBox.Show("Please add parent details for the student.",
                    "Parent Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                btnAddParent.Focus();
                return false;
            }

            return true;
        }

        private void ShowValidationError(Control control, string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            if (control is TextBox textBox)
                textBox.SelectAll();
        }

        private void ShowSuccessMessage(int studentId)
        {
            string message = $"✅ Student added successfully!\n\n" +
                           $"Student ID: {studentId}\n" +
                           $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                           $"Date of Birth: {dtpDateOfBirth.Value:dd/MM/yyyy}";

            MessageBox.Show(message,
                "Success",
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

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-10);

            selectedLocationId = 0;
            selectedParentId = 0;

            txtFirstName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all fields?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetForm();
                ShowStatusMessage("All fields cleared", Color.FromArgb(149, 165, 166));
            }
        }

        private void LogStudentCreation(int studentId, string firstName, string lastName)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] New student created - " +
                               $"ID: {studentId}, Name: {firstName} {lastName}, " +
                               $"Location: {selectedLocationId}, Parent: {selectedParentId}";

            // يمكنك حفظ هذا في ملف Log أو قاعدة بيانات
            System.Diagnostics.Debug.WriteLine(logMessage);
        }

        // دالة مساعدة لحساب العمر من تاريخ الميلاد
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            int age = CalculateAge(dtpDateOfBirth.Value);
            lblAgeHint.Text = $"Age: {age} years";
            lblAgeHint.Visible = true;
        }
    }
}