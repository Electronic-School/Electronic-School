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
    public partial class UpdateStudentControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(52, 152, 219); // أزرق فاتح
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color SuccessColor = Color.FromArgb(46, 204, 113); // أخضر
        private readonly Color WarningColor = Color.FromArgb(230, 126, 34); // برتقالي

        // متغيرات
        private Student currentStudent;
        private bool isStudentLoaded = false;

        public UpdateStudentControl()
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
            StyleTextBox(txtFirstName);
            StyleTextBox(txtLastName);
            StyleTextBox(txtLocationId);
            StyleTextBox(txtParentId);

            // تصميم DatePicker
            dtpDob.Font = new Font("Segoe UI", 10);
            dtpDob.CalendarFont = new Font("Segoe UI", 9);

            // تصميم الأزرار
            StyleButton(btnSearch, PrimaryColor);
            StyleButton(btnSave, SuccessColor, true);
            StyleButton(btnEditLocation, Color.FromArgb(155, 89, 182)); // بنفسجي
            StyleButton(btnEditParent, Color.FromArgb(155, 89, 182)); // بنفسجي
            StyleButton(btnClear, Color.FromArgb(149, 165, 166)); // رمادي

            // إضافة ToolTips
            toolTip.SetToolTip(txtStudentId, "Enter student ID to search");
            toolTip.SetToolTip(btnSearch, "Search for student by ID");
            toolTip.SetToolTip(txtFirstName, "Edit student's first name");
            toolTip.SetToolTip(txtLastName, "Edit student's last name");
            toolTip.SetToolTip(dtpDob, "Edit student's date of birth");
            toolTip.SetToolTip(txtLocationId, "Location ID (read-only)");
            toolTip.SetToolTip(txtParentId, "Parent ID (read-only)");
            toolTip.SetToolTip(btnEditLocation, "Edit location details");
            toolTip.SetToolTip(btnEditParent, "Edit parent details");
            toolTip.SetToolTip(btnSave, "Save changes to database");
            toolTip.SetToolTip(btnClear, "Clear all fields");

            // تعطيل الحقول في البداية
            SetFormEnabled(false);
        }

        private void StyleTextBox(System.Windows.Forms.TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10);
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
            txtLocationId.Enabled = false; // دائمًا read-only
            txtParentId.Enabled = false; // دائمًا read-only
            btnEditLocation.Enabled = enabled;
            btnEditParent.Enabled = enabled;
            btnSave.Enabled = enabled;
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
                        .Include(s => s.Parent)
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
                    txtLocationId.Text = currentStudent.LocationId.ToString();
                    txtParentId.Text = currentStudent.ParentId.ToString();

                    // تمكين الحقول
                    SetFormEnabled(true);
                    isStudentLoaded = true;

                    // عرض رسالة نجاح
                    ShowStatusMessage($"Student found: {currentStudent.FirstName} {currentStudent.LastName}", SuccessColor);

                    txtFirstName.Focus();
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

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (!isStudentLoaded)
            {
                MessageBox.Show("Please search for a student first.",
                    "No Student Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtLocationId.Text, out int locationId))
            {
                MessageBox.Show("Invalid Location ID",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var locationControl = new AddLocationControl(locationId);
            locationControl.LocationCreated += (newLocationId) =>
            {
                txtLocationId.Text = newLocationId.ToString();
                ShowStatusMessage("Location updated successfully", SuccessColor);

                // تحديث بيانات الطالب إذا تم تحميله
                if (currentStudent != null)
                {
                    currentStudent.LocationId = newLocationId;
                }
            };

            Form locationForm = new Form
            {
                Text = "Edit Location",
                Size = new Size(500, 400),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            locationControl.Dock = DockStyle.Fill;
            locationForm.Controls.Add(locationControl);
            locationForm.ShowDialog();
        }

        private void btnEditParent_Click(object sender, EventArgs e)
        {
            if (!isStudentLoaded)
            {
                MessageBox.Show("Please search for a student first.",
                    "No Student Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtParentId.Text, out int parentId))
            {
                MessageBox.Show("Invalid Parent ID",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var parentControl = new ParentAddControl(parentId);
            parentControl.ParentCreated += (newParentId) =>
            {
                txtParentId.Text = newParentId.ToString();
                ShowStatusMessage("Parent updated successfully", SuccessColor);

                // تحديث بيانات الطالب إذا تم تحميله
                if (currentStudent != null)
                {
                    currentStudent.ParentId = newParentId;
                }
            };

            Form parentForm = new Form
            {
                Text = "Edit Parent",
                Size = new Size(500, 450),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            parentControl.Dock = DockStyle.Fill;
            parentForm.Controls.Add(parentControl);
            parentForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isStudentLoaded || currentStudent == null)
            {
                MessageBox.Show("Please search for a student first.",
                    "No Student Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSave.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    // إعادة تحميل الطالب لضمان أن لدينا أحدث نسخة
                    var studentToUpdate = context.Students.Find(currentStudent.StudentsId);

                    if (studentToUpdate == null)
                    {
                        MessageBox.Show("Student no longer exists in database.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    // تحديث البيانات
                    studentToUpdate.FirstName = txtFirstName.Text.Trim();
                    studentToUpdate.LastName = txtLastName.Text.Trim();
                    studentToUpdate.DateOfBirth = dtpDob.Value.Date;

                    // تحديث IDs إذا تم التعديل
                    if (int.TryParse(txtLocationId.Text, out int locationId))
                        studentToUpdate.LocationId = locationId;

                    if (int.TryParse(txtParentId.Text, out int parentId))
                        studentToUpdate.ParentId = parentId;

                    

                    // حفظ التغييرات
                    context.SaveChanges();

                    // تحديث الكائن الحالي
                    currentStudent = studentToUpdate;

                    // عرض رسالة النجاح
                    ShowSuccessMessage(currentStudent.StudentsId);

                    // تسجيل التعديل
                    LogUpdate(currentStudent.StudentsId);
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
                MessageBox.Show($"Error saving changes:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSave.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            // التحقق من الاسم الأول
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // التحقق من الاسم الأخير
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // التحقق من تاريخ الميلاد
            if (dtpDob.Value > DateTime.Today)
            {
                MessageBox.Show("Date of birth cannot be in the future.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpDob.Focus();
                return false;
            }

            // التحقق من Location ID
            if (!int.TryParse(txtLocationId.Text, out int locationId) || locationId <= 0)
            {
                MessageBox.Show("Invalid Location ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            // التحقق من Parent ID
            if (!int.TryParse(txtParentId.Text, out int parentId) || parentId <= 0)
            {
                MessageBox.Show("Invalid Parent ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
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
                ShowStatusMessage("All fields cleared", Color.FromArgb(149, 165, 166));
            }
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtLocationId.Clear();
            txtParentId.Clear();
            dtpDob.Value = DateTime.Today.AddYears(-10);

            txtStudentId.Focus();
        }

        private void ShowSuccessMessage(int studentId)
        {
            string message = $"✅ Student updated successfully!\n\n" +
                           $"Student ID: {studentId}\n" +
                           $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                           $"Date of Birth: {dtpDob.Value:dd/MM/yyyy}";

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

        private void LogUpdate(int studentId)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Student updated - " +
                               $"ID: {studentId}, Name: {txtFirstName.Text} {txtLastName.Text}";

            System.Diagnostics.Debug.WriteLine(logMessage);
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