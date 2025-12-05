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
        // ألوان التصميم البيضاء والنظيفة
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185);    // أزرق فاتح
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح
        private readonly Color SuccessColor = Color.FromArgb(39, 174, 96);     // أخضر
        private readonly Color WarningColor = Color.FromArgb(243, 156, 18);    // برتقالي
        private readonly Color ErrorColor = Color.FromArgb(231, 76, 60);       // أحمر
        private readonly Color TextColor = Color.FromArgb(44, 62, 80);         // نص داكن

        // متغيرات للبيانات المحددة
        private int selectedLocationId = 0;
        private int selectedParentId = 0;
        private int selectedLevelId = 0;
        private SchoolDbContext _context;

        public event Action<int> StudentCreated;

        public AddStudentControl()
        {
            InitializeComponent();
            _context = new SchoolDbContext();
            ApplyCleanDesign();
            InitializeDatePicker();
            LoadStudentLevels();
        }

        private void ApplyCleanDesign()
        {
            // خلفية بيضاء نظيفة
            this.BackColor = Color.White;
            this.ForeColor = TextColor;

            // تلوين البانل العلوي
            pnlHeader.BackColor = PrimaryColor;
            lblTitle.ForeColor = Color.White;

            // تلوين البانل الرئيسي
            pnlForm.BackColor = Color.White;
            pnlForm.ForeColor = TextColor;

            // تصميم حقول الإدخال
            StyleCleanControl(txtFirstName);
            StyleCleanControl(txtLastName);
            StyleCleanComboBox(cmbLevel);
            StyleCleanDateTimePicker(dtpDateOfBirth);

            // تصميم الأزرار
            StyleCleanButton(btnAddLocation, PrimaryColor);
            StyleCleanButton(btnAddParent, PrimaryColor);
            StyleCleanButton(btnClear, WarningColor);
            StyleCleanButton(btnAddStudent, SuccessColor, true);

            // تصميم الـ Labels
            StyleCleanLabels();

            // إعداد ToolTips
            ConfigureToolTips();
        }

        private void StyleCleanControl(Control control)
        {
            if (control is TextBox textBox)
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = TextColor;
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.Font = new Font("Segoe UI", 10);
            }
        }

        private void StyleCleanComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.FromArgb(44, 62, 80);
            comboBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownHeight = 200;
            comboBox.Width = 350;
        }

        private void StyleCleanDateTimePicker(DateTimePicker dtp)
        {
            dtp.BackColor = Color.White;
            dtp.ForeColor = TextColor;
            dtp.Font = new Font("Segoe UI", 10);
            dtp.CalendarTitleBackColor = PrimaryColor;
            dtp.CalendarTitleForeColor = Color.White;
        }

        private void StyleCleanButton(Button button, Color backColor, bool isPrimary = false)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI Semibold", isPrimary ? 11 : 10);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(12, 7, 12, 7);

            button.MouseEnter += (s, e) =>
                button.BackColor = Color.FromArgb(
                    Math.Min(backColor.R + 15, 255),
                    Math.Min(backColor.G + 15, 255),
                    Math.Min(backColor.B + 15, 255));
            button.MouseLeave += (s, e) => button.BackColor = backColor;
        }

        private void StyleCleanLabels()
        {
            foreach (Control control in pnlForm.Controls)
            {
                if (control is Label label && !label.Name.StartsWith("lblStatus"))
                {
                    label.ForeColor = TextColor;
                    label.Font = new Font("Segoe UI Semibold", 10);
                }
            }

            lblStatus.ForeColor = SuccessColor;
            lblAgeHint.ForeColor = Color.Gray;
            lblLocationStatus.ForeColor = SuccessColor;
            lblParentStatus.ForeColor = SuccessColor;
        }

        private void ConfigureToolTips()
        {
            toolTip.BackColor = Color.White;
            toolTip.ForeColor = TextColor;
            toolTip.ToolTipTitle = "Student Information";

            toolTip.SetToolTip(txtFirstName, "Enter student's first name");
            toolTip.SetToolTip(txtLastName, "Enter student's last name");
            toolTip.SetToolTip(dtpDateOfBirth, "Select date of birth");
            toolTip.SetToolTip(cmbLevel, "Select academic level (required)");
            toolTip.SetToolTip(btnAddLocation, "Add location details (required)");
            toolTip.SetToolTip(btnAddParent, "Add parent details (required)");
            toolTip.SetToolTip(btnAddStudent, "Save new student");
            toolTip.SetToolTip(btnClear, "Clear all fields");
        }

        private void InitializeDatePicker()
        {
            dtpDateOfBirth.MinDate = new DateTime(1990, 1, 1);
            dtpDateOfBirth.MaxDate = DateTime.Today;
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-10);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
        }

        private void LoadStudentLevels()
        {
            try
            {
                cmbLevel.Items.Clear();
                cmbLevel.Items.Add(new ComboBoxItem { Text = "-- اختر المستوى الدراسي --", Value = 0 });

                var levels = _context.StudentLevels
                    .OrderBy(l => l.LevelNumber)
                    .ToList();

                if (levels.Any())
                {
                    foreach (var level in levels)
                    {
                        cmbLevel.Items.Add(new ComboBoxItem
                        {
                            Text = $"{level.LevelName}",
                            Value = level.LevelId,
                            Tag = level
                        });
                    }

                    cmbLevel.SelectedIndex = 0;
                    cmbLevel.Enabled = true;
                }
                else
                {
                    cmbLevel.Items.Add("⚠️ لم يتم العثور على مستويات دراسية");
                    cmbLevel.SelectedIndex = 0;
                    cmbLevel.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                cmbLevel.Items.Clear();
                cmbLevel.Items.Add("❌ خطأ في تحميل المستويات");
                cmbLevel.SelectedIndex = 0;
                cmbLevel.Enabled = false;

                MessageBox.Show($"خطأ في تحميل المستويات الدراسية:\n{ex.Message}",
                    "خطأ في قاعدة البيانات",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbLevel.SelectedItem as ComboBoxItem;
            if (selectedItem != null && selectedItem.Value > 0)
            {
                selectedLevelId = selectedItem.Value;

                if (selectedItem.Tag is StudentLevel level)
                {
                    toolTip.SetToolTip(cmbLevel,
                        $"Level: {level.LevelName}\n" +
                        $"Grade: {level.LevelNumber}\n" +
                        $"Stage: {level.Stage}\n" +
                        $"Students in this level: {level.Students?.Count ?? 0}");
                }

                lblLevelError.Visible = false;
            }
            else
            {
                selectedLevelId = 0;
            }
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
                lblLocationStatus.Text = $"✓ Location Selected (ID: {locationId})";
                lblLocationStatus.Visible = true;
                ShowStatusMessage($"Location added successfully!", SuccessColor);
                lblLocationError.Visible = false;
            };

            Form locationForm = new Form
            {
                Text = "📍 Add Location",
                Size = new Size(500, 400),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                BackColor = Color.White,
                ForeColor = TextColor
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
                lblParentStatus.Text = $"✓ Parent Selected (ID: {parentId})";
                lblParentStatus.Visible = true;
                ShowStatusMessage($"Parent added successfully!", SuccessColor);
                lblParentError.Visible = false;
            };

            Form parentForm = new Form
            {
                Text = "👤 Add Parent",
                Size = new Size(500, 450),
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                BackColor = Color.White,
                ForeColor = TextColor
            };

            parentControl.Dock = DockStyle.Fill;
            parentForm.Controls.Add(parentControl);
            parentForm.ShowDialog();
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnAddStudent.Enabled = false;
                btnAddStudent.Text = "⏳ Saving...";

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        // جلب البيانات من قاعدة البيانات للتحقق
                        var location = await _context.Locations.FindAsync(selectedLocationId);
                        var parent = await _context.Parents.FindAsync(selectedParentId);
                        var level = await _context.StudentLevels.FindAsync(selectedLevelId);

                        if (location == null || parent == null || level == null)
                        {
                            MessageBox.Show("Please select valid location, parent, and level.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // ⭐⭐ إنشاء الطالب الجديد - الطريقة الصحيحة ⭐⭐
                        var newStudent = new Student
                        {
                            FirstName = txtFirstName.Text.Trim(),
                            LastName = txtLastName.Text.Trim(),
                            DateOfBirth = dtpDateOfBirth.Value.Date,

                            
                            LocationId = selectedLocationId,
                            ParentId = selectedParentId,
                            LevelId = selectedLevelId,

                            Location = location,
                            Parent = parent,
                            StudentLevel = level
                        };

                        await _context.Students.AddAsync(newStudent);
                        await _context.SaveChangesAsync();
                        await transaction.CommitAsync();

                        // عرض رسالة النجاح
                        ShowSuccessMessage(newStudent.StudentsId);

                        // إطلاق الحدث
                        StudentCreated?.Invoke(newStudent.StudentsId);

                        // تسجيل في Log
                        LogStudentCreation(newStudent);

                        // إعادة تعيين النموذج
                        ResetForm();
                        ShowStatusMessage("Student saved successfully!", SuccessColor);
                    }
                    catch (DbUpdateException dbEx)
                    {
                        await transaction.RollbackAsync();

                        string errorMsg = dbEx.InnerException?.Message ?? dbEx.Message;
                        if (errorMsg.Contains("FK_"))
                        {
                            MessageBox.Show("Foreign key constraint error. Please check if all related records exist.",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Database error: {errorMsg}",
                                "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"Error saving student: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save student:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnAddStudent.Enabled = true;
                btnAddStudent.Text = "💾 Save Student";
            }
        }

        private bool ValidateInputs()
        {
            ClearAllErrors();
            bool isValid = true;

            // الاسم الأول
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowFieldError(lblFirstNameError, "Required");
                isValid = false;
            }
            else if (txtFirstName.Text.Trim().Length < 2)
            {
                ShowFieldError(lblFirstNameError, "Min 2 characters");
                isValid = false;
            }

            // الاسم الأخير
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowFieldError(lblLastNameError, "Required");
                isValid = false;
            }
            else if (txtLastName.Text.Trim().Length < 2)
            {
                ShowFieldError(lblLastNameError, "Min 2 characters");
                isValid = false;
            }

            // المستوى الدراسي
            if (selectedLevelId == 0)
            {
                ShowFieldError(lblLevelError, "Required");
                isValid = false;
            }

            // تاريخ الميلاد
            if (dtpDateOfBirth.Value > DateTime.Today)
            {
                ShowFieldError(lblDateOfBirthError, "Cannot be in future");
                isValid = false;
            }

            // الموقع
            if (selectedLocationId == 0)
            {
                ShowFieldError(lblLocationError, "Required");
                isValid = false;
            }

            // ولي الأمر
            if (selectedParentId == 0)
            {
                ShowFieldError(lblParentError, "Required");
                isValid = false;
            }

            if (!isValid)
            {
                ShowStatusMessage("Please correct the errors above", ErrorColor);
            }

            return isValid;
        }

        private void ClearAllErrors()
        {
            lblFirstNameError.Visible = false;
            lblLastNameError.Visible = false;
            lblLevelError.Visible = false;
            lblDateOfBirthError.Visible = false;
            lblLocationError.Visible = false;
            lblParentError.Visible = false;
        }

        private void ShowFieldError(Label errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = ErrorColor;
            errorLabel.Visible = true;
        }

        private void ShowSuccessMessage(int studentId)
        {
            string message = $"✅ Student saved successfully!\n\n" +
                           $"ID: {studentId}\n" +
                           $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                           $"Date of Birth: {dtpDateOfBirth.Value:dd/MM/yyyy}\n" +
                           $"Level: {cmbLevel.Text}";

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

            await Task.Delay(4000);
            lblStatus.Visible = false;
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-10);
            cmbLevel.SelectedIndex = 0;

            selectedLocationId = 0;
            selectedParentId = 0;
            selectedLevelId = 0;

            lblLocationStatus.Visible = false;
            lblParentStatus.Visible = false;
            ClearAllErrors();

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
                ShowStatusMessage("All fields cleared", WarningColor);
            }
        }

        private void LogStudentCreation(Student student)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Student created - " +
                               $"ID: {student.StudentsId}, " +
                               $"Name: {student.FirstName} {student.LastName}, " +
                               $"LevelId: {student.LevelId}, " +
                               $"LocationId: {student.LocationId}, " +
                               $"ParentId: {student.ParentId}";

            System.Diagnostics.Debug.WriteLine(logMessage);
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateOfBirth.Value <= DateTime.Today)
            {
                int age = CalculateAge(dtpDateOfBirth.Value);
                lblAgeHint.Text = $"Age: {age} years";
                lblAgeHint.Visible = true;
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        // فئة مساعدة للكومبو بوكس
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public object Tag { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {
            // Empty handler
        }
    }
}