using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class UpdateStudentControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(44, 62, 80);
        private readonly Color SuccessColor = Color.FromArgb(39, 174, 96);

        // متغيرات
        private Student currentStudent;
        private bool isStudentLoaded = false;

        public UpdateStudentControl()
        {
            InitializeComponent();
            ApplyModernDesign();
            InitializeDatePicker();
            InitializeStudentLevelComboBox();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;
            pnlHeader.BackColor = PrimaryColor;

            // تصميم حقول الإدخال
            StyleTextBox(txtStudentId);
            StyleTextBox(txtFirstName);
            StyleTextBox(txtLastName);
            StyleTextBox(txtLocationId);
            StyleTextBox(txtParentId);

            // تصميم ComboBox
            cmbStudentLevel.Font = new Font("Segoe UI", 10);
            cmbStudentLevel.BackColor = Color.White;

            // تصميم DatePicker
            dtpDob.Font = new Font("Segoe UI", 10);

            // تصميم الأزرار
            StyleButton(btnSearch, PrimaryColor);
            StyleButton(btnSave, SuccessColor);
            StyleButton(btnEditLocation, PrimaryColor);
            StyleButton(btnEditParent, PrimaryColor);
            StyleButton(btnClear, Color.FromArgb(149, 165, 166));

            SetFormEnabled(false);
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10);
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

        private void InitializeDatePicker()
        {
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.MinDate = new DateTime(1900, 1, 1);
            dtpDob.MaxDate = DateTime.Today;
        }

        private void InitializeStudentLevelComboBox()
        {
            cmbStudentLevel.Items.Clear();
            cmbStudentLevel.Items.Add("Select Student Level");

            try
            {
                using (var context = new SchoolDbContext())
                {
                    // جلب جميع المستويات الدراسية من قاعدة البيانات
                    var levels = context.StudentLevels
                        .OrderBy(l => l.LevelNumber)
                        .ToList();

                    foreach (var level in levels)
                    {
                        cmbStudentLevel.Items.Add($"{level.LevelName} ({level.Stage})");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student levels: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbStudentLevel.SelectedIndex = 0;
        }

        private void SetFormEnabled(bool enabled)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            cmbStudentLevel.Enabled = enabled;
            dtpDob.Enabled = enabled;
            txtLocationId.Enabled = false;
            txtParentId.Enabled = false;
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
                    dtpDob.Value = currentStudent.DateOfBirth ?? DateTime.Today.AddYears(-10);
                    txtLocationId.Text = currentStudent.LocationId.ToString();
                    txtParentId.Text = currentStudent.ParentId.ToString();

                    // تعبئة Student Level
                    if (currentStudent.StudentLevel != null)
                    {
                        // البحث في ComboBox بناءً على LevelName
                        string levelDisplay = $"{currentStudent.StudentLevel.LevelName} ({currentStudent.StudentLevel.Stage})";
                        int index = cmbStudentLevel.FindString(levelDisplay);
                        cmbStudentLevel.SelectedIndex = index >= 0 ? index : 0;
                    }
                    else
                    {
                        cmbStudentLevel.SelectedIndex = 0;
                    }

                    SetFormEnabled(true);
                    isStudentLoaded = true;
                    txtFirstName.Focus();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isStudentLoaded || currentStudent == null)
            {
                MessageBox.Show("Please search for a student first.",
                    "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    var studentToUpdate = context.Students.Find(currentStudent.StudentId);

                    if (studentToUpdate == null)
                    {
                        MessageBox.Show("Student no longer exists in database.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // تحديث البيانات
                    studentToUpdate.FirstName = txtFirstName.Text.Trim();
                    studentToUpdate.LastName = txtLastName.Text.Trim();
                    studentToUpdate.DateOfBirth = dtpDob.Value.Date;

                    // تحديث Student Level
                    if (cmbStudentLevel.SelectedIndex > 0)
                    {
                        try
                        {
                            string selectedLevel = cmbStudentLevel.SelectedItem.ToString();

                            // استخراج LevelName من النص
                            string levelName = selectedLevel.Split('(')[0].Trim();

                            // البحث عن المستوى في قاعدة البيانات
                            var level = context.StudentLevels
                                .FirstOrDefault(l => l.LevelName == levelName);

                            if (level != null)
                            {
                                
                                studentToUpdate.LevelId = level.LevelId;
                                
                            }
                        }
                        catch (Exception)
                        {
                            // يمكن تجاهل الخطأ أو تسجيله
                        }
                    }

                    // تحديث Location و Parent IDs
                    if (int.TryParse(txtLocationId.Text, out int locationId))
                        studentToUpdate.LocationId = locationId;

                    if (int.TryParse(txtParentId.Text, out int parentId))
                        studentToUpdate.ParentId = parentId;

                    // حفظ التغييرات
                    context.SaveChanges();
                    currentStudent = studentToUpdate;

                    MessageBox.Show("Student updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}",
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSave.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (cmbStudentLevel.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a student level.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStudentLevel.Focus();
                return false;
            }

            if (dtpDob.Value > DateTime.Today)
            {
                MessageBox.Show("Date of birth cannot be in the future.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDob.Focus();
                return false;
            }

            if (!int.TryParse(txtLocationId.Text, out int locationId) || locationId <= 0)
            {
                MessageBox.Show("Invalid Location ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtParentId.Text, out int parentId) || parentId <= 0)
            {
                MessageBox.Show("Invalid Parent ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all fields?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearForm();
                SetFormEnabled(false);
                isStudentLoaded = false;
                currentStudent = null;
            }
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtLocationId.Clear();
            txtParentId.Clear();
            cmbStudentLevel.SelectedIndex = 0;
            dtpDob.Value = DateTime.Today.AddYears(-10);
            txtStudentId.Focus();
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (!isStudentLoaded)
            {
                MessageBox.Show("Please search for a student first.",
                    "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtLocationId.Text, out int locationId))
            {
                MessageBox.Show("Invalid Location ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var locationControl = new AddLocationControl(locationId);
            locationControl.LocationCreated += (newLocationId) =>
            {
                txtLocationId.Text = newLocationId.ToString();
                if (currentStudent != null) currentStudent.LocationId = newLocationId;
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
                    "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtParentId.Text, out int parentId))
            {
                MessageBox.Show("Invalid Parent ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parentControl = new ParentAddControl(parentId);
            parentControl.ParentCreated += (newParentId) =>
            {
                txtParentId.Text = newParentId.ToString();
                if (currentStudent != null) currentStudent.ParentId = newParentId;
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
    }
}