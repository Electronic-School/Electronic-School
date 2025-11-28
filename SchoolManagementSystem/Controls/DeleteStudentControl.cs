using System;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controls
{
    public partial class DeleteStudentControl : UserControl
    {
        private int _currentStudentId;
        private Student _currentStudent;

        public event EventHandler OnStudentDeleted;

        public DeleteStudentControl()
        {
            InitializeComponent();
            ClearStudentInfo();
            DisableDeleteButton();
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
                _currentStudent = db.Students.FirstOrDefault(s => s.STUDENTID == _currentStudentId);

                if (_currentStudent == null)
                {
                    MessageBox.Show("الطالب غير موجود في النظام", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearStudentInfo();
                    DisableDeleteButton();
                    return;
                }

                DisplayStudentInfo();
                EnableDeleteButton();
                MessageBox.Show("تم تحميل بيانات الطالب بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearStudentInfo();
                DisableDeleteButton();
            }
        }

        private void DisplayStudentInfo()
        {
            lblName.Text = $"الاسم: {_currentStudent.FIRSTNAME} {_currentStudent.LASTNAME}";
            lblLocationId.Text = $"رقم الموقع: {_currentStudent.LOCATIONID}";
            lblParentId.Text = $"رقم الأب: {_currentStudent.ParentId}";

            // تغيير لون الخلفية للإشارة إلى تحميل البيانات
            pnlStudentInfo.BackColor = System.Drawing.Color.FromArgb(240, 255, 240);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentStudentId <= 0 || _currentStudent == null)
            {
                MessageBox.Show("الرجاء تحميل بيانات الطالب أولاً", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"هل أنت متأكد من حذف الطالب التالي؟\n\n" +
                $"الاسم: {_currentStudent.FIRSTNAME} {_currentStudent.LASTNAME}\n" +
                $"رقم الموقع: {_currentStudent.LOCATIONID}\n" +
                $"رقم الأب: {_currentStudent.ParentId}\n\n" +
                $"هذا الإجراء لا يمكن التراجع عنه!",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                DeleteStudent();
            }
        }

        private void DeleteStudent()
        {
            try
            {
                using var db = new AppDbContext();
                var student = db.Students.FirstOrDefault(s => s.STUDENTID == _currentStudentId);

                if (student == null)
                {
                    MessageBox.Show("الطالب غير موجود في النظام", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearStudentInfo();
                    DisableDeleteButton();
                    return;
                }

                // حفظ المعلومات لعرضها في رسالة التأكيد
                string studentName = $"{student.FIRSTNAME} {student.LASTNAME}";

                db.Students.Remove(student);
                db.SaveChanges();

                MessageBox.Show($"تم حذف الطالب ({studentName}) بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                DisableDeleteButton();
                OnStudentDeleted?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حذف الطالب: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableDeleteButton();
        }

        private void ClearForm()
        {
            txtStudentId.Text = "";
            ClearStudentInfo();
            _currentStudentId = 0;
            _currentStudent = null;
        }

        private void ClearStudentInfo()
        {
            lblName.Text = "الاسم: ---";
            lblLocationId.Text = "رقم الموقع: ---";
            lblParentId.Text = "رقم الأب: ---";

            // إعادة لون الخلفية إلى الوضع الطبيعي
            pnlStudentInfo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void EnableDeleteButton()
        {
            btnDelete.Enabled = true;
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnClear.Enabled = true;
        }

        private void DisableDeleteButton()
        {
            btnDelete.Enabled = false;
            btnDelete.BackColor = System.Drawing.Color.LightGray;
            btnClear.Enabled = true;
        }

        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والتحكم (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // السماح بالضغط على Enter لتحميل البيانات
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLoad_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            // إذا تم مسح رقم الطالب، تعطيل زر الحذف
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                ClearStudentInfo();
                DisableDeleteButton();
            }
        }

        private void ShowStudentDetails(object sender, EventArgs e)
        {
            if (_currentStudent != null)
            {
                string details = $"تفاصيل الطالب:\n\n" +
                               $"الاسم الكامل: {_currentStudent.FIRSTNAME} {_currentStudent.LASTNAME}\n" +
                               $"رقم الموقع: {_currentStudent.LOCATIONID}\n" +
                               $"رقم الأب: {_currentStudent.ParentId}";

                MessageBox.Show(details, "تفاصيل الطالب",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}