using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Controls
{
    public partial class AddStudentControl : UserControl
    {
        public event EventHandler OnStudentAdded;

        public AddStudentControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using var db = new SchoolDbContext();
                var student = new Student
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    LocationId = int.Parse(txtLocationId.Text),
                    ParentId = int.Parse(txtParentId.Text)
                };

                db.Students.Add(student);
                db.SaveChanges();

                MessageBox.Show("تم إضافة الطالب بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                OnStudentAdded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في إضافة الطالب: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأول", "تحذير");
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("الرجاء إدخال الاسم الأخير", "تحذير");
                txtLastName.Focus();
                return false;
            }

            if (!int.TryParse(txtLocationId.Text, out int locationId) || locationId <= 0)
            {
                MessageBox.Show("الرجاء إدخال رقم موقع صحيح", "تحذير");
                txtLocationId.Focus();
                return false;
            }

            if (!int.TryParse(txtParentId.Text, out int parentId) || parentId <= 0)
            {
                MessageBox.Show("الرجاء إدخال رقم أب صحيح", "تحذير");
                txtParentId.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtLocationId.Text = "";
            txtParentId.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}