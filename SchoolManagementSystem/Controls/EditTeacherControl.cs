using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controls
{
    public partial class UC_UpdateTeacher : UserControl
    {
        private int _currentTeacherId;

        public event EventHandler OnTeacherUpdated;

        public UC_UpdateTeacher()
        {
            InitializeComponent();
            DisableForm();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!ValidateTeacherId())
                return;

            LoadTeacherData();
        }

        private bool ValidateTeacherId()
        {
            if (string.IsNullOrWhiteSpace(txtTeacherId.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم المدرس", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherId.Focus();
                return false;
            }

            if (!int.TryParse(txtTeacherId.Text, out int teacherId) || teacherId <= 0)
            {
                MessageBox.Show("الرجاء إدخال رقم مدرس صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherId.Focus();
                return false;
            }

            _currentTeacherId = teacherId;
            return true;
        }

        private void LoadTeacherData()
        {
            try
            {
                using var db = new AppDbContext();
                var teacher = db.Teachers.FirstOrDefault(t => t.ID == _currentTeacherId);

                if (teacher == null)
                {
                    MessageBox.Show("المدرس غير موجود في النظام", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DisableForm();
                    return;
                }

                FillFormWithTeacherData(teacher);
                EnableForm();
                MessageBox.Show("تم تحميل بيانات المدرس بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableForm();
            }
        }

        private void FillFormWithTeacherData(Teacher teacher)
        {
            txtFirstName.Text = teacher.FirstName;
            txtLastName.Text = teacher.LastName;

            if (teacher.DateOfBirth.HasValue)
                dtpDateOfBirth.Value = teacher.DateOfBirth.Value;

            txtSalary.Text = teacher.Salary?.ToString("F2");
            txtEducationDegree.Text = teacher.EducationDegree;
            txtTeachingSubject.Text = teacher.TeachingSubject;

            if (teacher.StartWorkingDate.HasValue)
                dtpStartWorkingDate.Value = teacher.StartWorkingDate.Value;

            txtNumberOfVacations.Text = teacher.NumberOfVacations?.ToString();
            txtPhoneNumber.Text = teacher.PhoneNumber;
            txtEmail.Text = teacher.Email;

            if (!string.IsNullOrEmpty(teacher.SocialStatus))
            {
                cmbSocialStatus.SelectedItem = teacher.SocialStatus;
            }
            else
            {
                cmbSocialStatus.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentTeacherId <= 0)
            {
                MessageBox.Show("الرجاء تحميل بيانات المدرس أولاً", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            var result = MessageBox.Show("هل أنت متأكد من تعديل بيانات المدرس؟", "تأكيد التعديل",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateTeacher();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأول", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأخير", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("الرجاء إدخال راتب صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalary.Focus();
                return false;
            }

            if (!int.TryParse(txtNumberOfVacations.Text, out int vacations) || vacations < 0)
            {
                MessageBox.Show("الرجاء إدخال عدد إجازات صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberOfVacations.Focus();
                return false;
            }

            if (cmbSocialStatus.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار الحالة الاجتماعية", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSocialStatus.Focus();
                return false;
            }

            // التحقق من البريد الإلكتروني إذا تم إدخاله
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("الرجاء إدخال بريد إلكتروني صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void UpdateTeacher()
        {
            try
            {
                using var db = new AppDbContext();
                var teacher = db.Teachers.FirstOrDefault(t => t.ID == _currentTeacherId);

                if (teacher == null)
                {
                    MessageBox.Show("المدرس غير موجود في النظام", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisableForm();
                    return;
                }

                // تحديث البيانات
                teacher.FirstName = txtFirstName.Text.Trim();
                teacher.LastName = txtLastName.Text.Trim();
                teacher.DateOfBirth = dtpDateOfBirth.Value;
                teacher.Salary = decimal.Parse(txtSalary.Text);
                teacher.EducationDegree = txtEducationDegree.Text.Trim();
                teacher.TeachingSubject = txtTeachingSubject.Text.Trim();
                teacher.StartWorkingDate = dtpStartWorkingDate.Value;
                teacher.NumberOfVacations = int.Parse(txtNumberOfVacations.Text);
                teacher.PhoneNumber = txtPhoneNumber.Text.Trim();
                teacher.Email = txtEmail.Text.Trim();
                teacher.SocialStatus = cmbSocialStatus.SelectedItem?.ToString();

                db.SaveChanges();

                MessageBox.Show("تم تعديل بيانات المدرس بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnTeacherUpdated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تعديل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableForm();
        }

        private void ClearForm()
        {
            txtTeacherId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
            txtSalary.Text = "";
            txtEducationDegree.Text = "";
            txtTeachingSubject.Text = "";
            dtpStartWorkingDate.Value = DateTime.Now;
            txtNumberOfVacations.Text = "0";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cmbSocialStatus.SelectedIndex = -1;
            _currentTeacherId = 0;
        }

        private void EnableForm()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            txtSalary.Enabled = true;
            txtEducationDegree.Enabled = true;
            txtTeachingSubject.Enabled = true;
            dtpStartWorkingDate.Enabled = true;
            txtNumberOfVacations.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtEmail.Enabled = true;
            cmbSocialStatus.Enabled = true;
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
        }

        private void DisableForm()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            dtpDateOfBirth.Enabled = false;
            txtSalary.Enabled = false;
            txtEducationDegree.Enabled = false;
            txtTeachingSubject.Enabled = false;
            dtpStartWorkingDate.Enabled = false;
            txtNumberOfVacations.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmail.Enabled = false;
            cmbSocialStatus.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والتحكم (Backspace) والنقطة
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // السماح بنقطة واحدة فقط
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtNumberOfVacations_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والتحكم (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والتحكم (Backspace) وعلامة +
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والتحكم (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}