using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controls
{
    public partial class EditStudentControl : UserControl
    {
        private int _currentStudentId;

        public event EventHandler OnStudentUpdated;

        public EditStudentControl()
        {
            InitializeComponent();
            DisableForm();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentId())
                return;

            LoadStudentData();
        }

        private bool ValidateStudentId()
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الطالب", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return false;
            }

            if (!int.TryParse(txtStudentId.Text, out int studentId) || studentId <= 0)
            {
                MessageBox.Show("الرجاء إدخال رقم طالب صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return false;
            }

            _currentStudentId = studentId;
            return true;
        }

        private void LoadStudentData()
        {
            try
            {
                using var db = new AppDbContext();
                var student = db.Students.FirstOrDefault(s => s.STUDENTID == _currentStudentId);

                if (student == null)
                {
                    MessageBox.Show("الطالب غير موجود في النظام", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DisableForm();
                    return;
                }

                FillFormWithStudentData(student);
                EnableForm();
                MessageBox.Show("تم تحميل بيانات الطالب بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableForm();
            }
        }

        private void FillFormWithStudentData(Student student)
        {
            txtFirstName.Text = student.FIRSTNAME;
            txtLastName.Text = student.LASTNAME;
            txtLocationId.Text = student.LOCATIONID.ToString();
            txtParentId.Text = student.ParentId.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentStudentId <= 0)
            {
                MessageBox.Show("الرجاء تحميل بيانات الطالب أولاً", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            var result = MessageBox.Show("هل أنت متأكد من تعديل بيانات الطالب؟", "تأكيد التعديل",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateStudent();
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

            if (!int.TryParse(txtLocationId.Text, out int locationId) || locationId <= 0)
            {
                MessageBox.Show("الرجاء إدخال رقم موقع صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocationId.Focus();
                return false;
            }

            if (!int.TryParse(txtParentId.Text, out int parentId) || parentId <= 0)
            {
                MessageBox.Show("الرجاء إدخال رقم أب صحيح", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParentId.Focus();
                return false;
            }

            return true;
        }

        private void UpdateStudent()
        {
            try
            {
                using var db = new AppDbContext();
                var student = db.Students.FirstOrDefault(s => s.STUDENTID == _currentStudentId);

                if (student == null)
                {
                    MessageBox.Show("الطالب غير موجود في النظام", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisableForm();
                    return;
                }

                // تحديث البيانات
                student.FIRSTNAME = txtFirstName.Text.Trim();
                student.LASTNAME = txtLastName.Text.Trim();
                student.LOCATIONID = int.Parse(txtLocationId.Text);
                student.ParentId = int.Parse(txtParentId.Text);

                db.SaveChanges();

                MessageBox.Show("تم تعديل بيانات الطالب بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnStudentUpdated?.Invoke(this, EventArgs.Empty);
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
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtLocationId.Text = "";
            txtParentId.Text = "";
            _currentStudentId = 0;
        }

        private void EnableForm()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtLocationId.Enabled = true;
            txtParentId.Enabled = true;
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
        }

        private void DisableForm()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtLocationId.Enabled = false;
            txtParentId.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
        }

        private void txtLocationId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtParentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}