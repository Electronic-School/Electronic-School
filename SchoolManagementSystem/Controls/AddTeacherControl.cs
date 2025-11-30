using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Models;


namespace SchoolManagementSystem.Controls
{
    public partial class UC_AddTeacher : UserControl
    {
        public event EventHandler OnTeacherAdded;

        public UC_AddTeacher()
        {
            InitializeComponent();
            SetDefaultDates();
        }

        private void SetDefaultDates()
        {
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
            dtpStartWorkingDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using var db = new SchoolDbContext();
                var teacher = new Teacher
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    DateOfBirth = dtpDateOfBirth.Value,
                    Salary = decimal.Parse(txtSalary.Text),
                    EducationDegree = txtEducationDegree.Text.Trim(),
                    TeachingSubject = txtTeachingSubject.Text.Trim(),
                    StartWorkingDate = dtpStartWorkingDate.Value,
                    NumberOfVacations = int.Parse(txtNumberOfVacations.Text),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    SocialStatus = cmbSocialStatus.SelectedItem?.ToString()
                };

                db.Teachers.Add(teacher);
                db.SaveChanges();

                MessageBox.Show("تم إضافة المدرس بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                SetDefaultDates();
                OnTeacherAdded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في إضافة المدرس: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSalary.Text = "";
            txtEducationDegree.Text = "";
            txtTeachingSubject.Text = "";
            txtNumberOfVacations.Text = "0";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cmbSocialStatus.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetDefaultDates();
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
    }
}