using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class UpdateTeacherControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(44, 62, 80);
        private readonly Color SuccessColor = Color.FromArgb(39, 174, 96);
        private readonly Color DefaultColor = Color.FromArgb(149, 165, 166);

        // متغيرات
        private Teacher currentTeacher;
        private bool isTeacherLoaded = false;

        public UpdateTeacherControl()
        {
            InitializeComponent();
            ApplyModernDesign();
            InitializeDatePickers();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;
            if (pnlHeader != null) pnlHeader.BackColor = PrimaryColor;

            // تصميم حقول الإدخال
            StyleTextBox(txtTeacherId);
            StyleTextBox(txtFirstName);
            StyleTextBox(txtLastName);
            StyleTextBox(txtSubject);
            StyleTextBox(txtDegree);
            StyleTextBox(txtSalary);
            StyleTextBox(txtPhone);
            StyleTextBox(txtEmail);
            StyleTextBox(txtSocialStatus);
            StyleTextBox(txtLocationId);

            // تصميم الأزرار
            StyleButton(btnSearch, PrimaryColor);
            StyleButton(btnSave, SuccessColor);
            StyleButton(btnEditLocation, PrimaryColor);
            StyleButton(btnClear, DefaultColor);

            SetFormEnabled(false);
        }

        private void StyleTextBox(TextBox textBox)
        {
            if (textBox != null)
            {
                textBox.BackColor = Color.White;
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.Font = new Font("Segoe UI", 10);
            }
        }

        private void StyleButton(Button button, Color backColor)
        {
            if (button != null)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = backColor;
                button.ForeColor = Color.White;
                button.Font = new Font("Segoe UI", 10);
                button.Cursor = Cursors.Hand;
            }
        }

        private void InitializeDatePickers()
        {
            if (dtpDob != null)
            {
                dtpDob.Format = DateTimePickerFormat.Short;
                dtpDob.MaxDate = DateTime.Today;
            }
            if (dtpStartWork != null)
            {
                dtpStartWork.Format = DateTimePickerFormat.Short;
                dtpStartWork.MaxDate = DateTime.Today;
            }
        }

        private void SetFormEnabled(bool enabled)
        {
            // تمكين/تعطيل الحقول القابلة للتعديل
            if (txtFirstName != null) txtFirstName.Enabled = enabled;
            if (txtLastName != null) txtLastName.Enabled = enabled;
            if (txtSubject != null) txtSubject.Enabled = enabled;
            if (txtDegree != null) txtDegree.Enabled = enabled;
            if (txtSalary != null) txtSalary.Enabled = enabled;
            if (txtPhone != null) txtPhone.Enabled = enabled;
            if (txtEmail != null) txtEmail.Enabled = enabled;
            if (txtSocialStatus != null) txtSocialStatus.Enabled = enabled;

            if (dtpDob != null) dtpDob.Enabled = enabled;
            if (dtpStartWork != null) dtpStartWork.Enabled = enabled;

            // حقل الموقع للقراءة فقط، التعديل يتم عبر الزر
            if (txtLocationId != null) txtLocationId.Enabled = false;

            if (btnEditLocation != null) btnEditLocation.Enabled = enabled;
            if (btnSave != null) btnSave.Enabled = enabled;
            if (btnClear != null) btnClear.Enabled = enabled;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTeacherId.Text.Trim(), out int teacherId))
            {
                MessageBox.Show("Please enter a valid numeric Teacher ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSearch.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    currentTeacher = context.Teachers
                        .Include(t => t.Location)
                        .FirstOrDefault(t => t.TeacherId == teacherId);

                    if (currentTeacher == null)
                    {
                        MessageBox.Show($"Teacher with ID {teacherId} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        return;
                    }

                    // تعبئة البيانات
                    txtFirstName.Text = currentTeacher.FirstName;
                    txtLastName.Text = currentTeacher.LastName;
                    txtSubject.Text = currentTeacher.TeachingSubject;
                    txtDegree.Text = currentTeacher.EducationDegree;
                    txtSalary.Text = currentTeacher.Salary?.ToString() ?? "";
                    txtPhone.Text = currentTeacher.PhoneNumber;
                    txtEmail.Text = currentTeacher.Email;
                    txtSocialStatus.Text = currentTeacher.SocialStatus;
                    txtLocationId.Text = currentTeacher.LocationId.ToString();

                    dtpDob.Value = currentTeacher.DateOfBirth ?? DateTime.Today.AddYears(-25);
                    dtpStartWork.Value = currentTeacher.StartWorkingDate ?? DateTime.Today;

                    SetFormEnabled(true);
                    isTeacherLoaded = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSearch.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isTeacherLoaded || currentTeacher == null) return;

            if (!ValidateInputs()) return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnSave.Enabled = false;

                using (var context = new SchoolDbContext())
                {
                    var teacherToUpdate = context.Teachers.Find(currentTeacher.TeacherId);

                    if (teacherToUpdate == null)
                    {
                        MessageBox.Show("Teacher no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // تحديث القيم
                    teacherToUpdate.FirstName = txtFirstName.Text.Trim();
                    teacherToUpdate.LastName = txtLastName.Text.Trim();
                    teacherToUpdate.TeachingSubject = txtSubject.Text.Trim();
                    teacherToUpdate.EducationDegree = txtDegree.Text.Trim();
                    teacherToUpdate.PhoneNumber = txtPhone.Text.Trim();
                    teacherToUpdate.Email = txtEmail.Text.Trim();
                    teacherToUpdate.SocialStatus = txtSocialStatus.Text.Trim();

                    teacherToUpdate.DateOfBirth = dtpDob.Value.Date;
                    teacherToUpdate.StartWorkingDate = dtpStartWork.Value.Date;

                    if (decimal.TryParse(txtSalary.Text.Trim(), out decimal salary))
                        teacherToUpdate.Salary = salary;
                    else
                        teacherToUpdate.Salary = null;

                    if (int.TryParse(txtLocationId.Text, out int locId))
                        teacherToUpdate.LocationId = locId;

                    context.SaveChanges();

                    MessageBox.Show("Teacher updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentTeacher = teacherToUpdate; // تحديث النسخة المحلية
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnSave.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtSubject.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill all required fields (Name, Subject, Phone).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (!isTeacherLoaded) return;

            if (int.TryParse(txtLocationId.Text, out int locId))
            {
                var locationControl = new AddLocationControl(locId);
                locationControl.LocationCreated += (newLocId) =>
                {
                    txtLocationId.Text = newLocId.ToString();
                    if (currentTeacher != null) currentTeacher.LocationId = newLocId;
                };

                Form locForm = new Form
                {
                    Text = "Edit Location",
                    Size = new Size(500, 450),
                    StartPosition = FormStartPosition.CenterParent
                };
                locationControl.Dock = DockStyle.Fill;
                locForm.Controls.Add(locationControl);
                locForm.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTeacherId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSubject.Clear();
            txtDegree.Clear();
            txtSalary.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSocialStatus.Clear();
            txtLocationId.Clear();

            dtpDob.Value = DateTime.Today.AddYears(-25);
            dtpStartWork.Value = DateTime.Today;

            SetFormEnabled(false);
            isTeacherLoaded = false;
            currentTeacher = null;
            txtTeacherId.Focus();
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }
    }
}