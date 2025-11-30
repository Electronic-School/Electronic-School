using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Controls
{
    public partial class UC_DeleteTeacher : UserControl
    {
        private int _currentTeacherId;
        private Teacher _currentTeacher;

        public event EventHandler OnTeacherDeleted;

        public UC_DeleteTeacher()
        {
            InitializeComponent();
            ClearTeacherInfo();
            DisableDeleteButton();
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
                using var db = new SchoolDbContext();
                _currentTeacher = db.Teachers.FirstOrDefault(t => t.TeacherId == _currentTeacherId);

                if (_currentTeacher == null)
                {
                    MessageBox.Show("المدرس غير موجود في النظام", "تحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearTeacherInfo();
                    DisableDeleteButton();
                    return;
                }

                DisplayTeacherInfo();
                EnableDeleteButton();
                MessageBox.Show("تم تحميل بيانات المدرس بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTeacherInfo();
                DisableDeleteButton();
            }
        }

        private void DisplayTeacherInfo()
        {
            lblName.Text = $"الاسم: {_currentTeacher.FirstName} {_currentTeacher.LastName}";
            lblDateOfBirth.Text = $"تاريخ الميلاد: {_currentTeacher.DateOfBirth?.ToString("yyyy/MM/dd") ?? "غير محدد"}";
            lblSalary.Text = $"الراتب: {_currentTeacher.Salary?.ToString("C2") ?? "غير محدد"}";
            lblEducationDegree.Text = $"المؤهل العلمي: {_currentTeacher.EducationDegree ?? "غير محدد"}";
            lblTeachingSubject.Text = $"المادة الدراسية: {_currentTeacher.TeachingSubject ?? "غير محدد"}";
            lblStartWorkingDate.Text = $"تاريخ بدء العمل: {_currentTeacher.StartWorkingDate?.ToString("yyyy/MM/dd") ?? "غير محدد"}";
            lblNumberOfVacations.Text = $"عدد الإجازات: {_currentTeacher.NumberOfVacations?.ToString() ?? "غير محدد"}";
            lblPhoneNumber.Text = $"رقم الهاتف: {_currentTeacher.PhoneNumber ?? "غير محدد"}";
            lblEmail.Text = $"البريد الإلكتروني: {_currentTeacher.Email ?? "غير محدد"}";
            lblSocialStatus.Text = $"الحالة الاجتماعية: {_currentTeacher.SocialStatus ?? "غير محدد"}";

            // تغيير لون الخلفية للإشارة إلى تحميل البيانات
            pnlTeacherInfo.BackColor = Color.FromArgb(240, 255, 240);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentTeacherId <= 0 || _currentTeacher == null)
            {
                MessageBox.Show("الرجاء تحميل بيانات المدرس أولاً", "تحذير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"هل أنت متأكد من حذف المدرس التالي؟\n\n" +
                $"الاسم: {_currentTeacher.FirstName} {_currentTeacher.LastName}\n" +
                $"رقم الهاتف: {_currentTeacher.PhoneNumber}\n\n" +
                $"هذا الإجراء لا يمكن التراجع عنه!",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                DeleteTeacher();
            }
        }

        private void DeleteTeacher()
        {
            try
            {
                using var db = new SchoolDbContext();
                var teacher = db.Teachers.FirstOrDefault(t => t.TeacherId == _currentTeacherId);

                if (teacher == null)
                {
                    MessageBox.Show("المدرس غير موجود في النظام", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearTeacherInfo();
                    DisableDeleteButton();
                    return;
                }

                // حفظ المعلومات لعرضها في رسالة التأكيد
                string teacherName = $"{teacher.FirstName} {teacher.LastName}";
                string teacherId = teacher.TeacherId.ToString();

                db.Teachers.Remove(teacher);
                db.SaveChanges();

                MessageBox.Show($"تم حذف المدرس ({teacherName}) بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                DisableDeleteButton();
                OnTeacherDeleted?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حذف المدرس: {ex.Message}", "خطأ",
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
            txtTeacherId.Text = "";
            ClearTeacherInfo();
            _currentTeacherId = 0;
            _currentTeacher = null;
        }

        private void ClearTeacherInfo()
        {
            lblName.Text = "الاسم: ---";
            lblDateOfBirth.Text = "تاريخ الميلاد: ---";
            lblSalary.Text = "الراتب: ---";
            lblEducationDegree.Text = "المؤهل العلمي: ---";
            lblTeachingSubject.Text = "المادة الدراسية: ---";
            lblStartWorkingDate.Text = "تاريخ بدء العمل: ---";
            lblNumberOfVacations.Text = "عدد الإجازات: ---";
            lblPhoneNumber.Text = "رقم الهاتف: ---";
            lblEmail.Text = "البريد الإلكتروني: ---";
            lblSocialStatus.Text = "الحالة الاجتماعية: ---";

            // إعادة لون الخلفية إلى الوضع الطبيعي
            pnlTeacherInfo.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void EnableDeleteButton()
        {
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.Red;
            btnClear.Enabled = true;
        }

        private void DisableDeleteButton()
        {
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.LightGray;
            btnClear.Enabled = true;
        }

        private void txtTeacherId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTeacherId_TextChanged(object sender, EventArgs e)
        {
            // إذا تم مسح رقم المدرس، تعطيل زر الحذف
            if (string.IsNullOrWhiteSpace(txtTeacherId.Text))
            {
                ClearTeacherInfo();
                DisableDeleteButton();
            }
        }

        private void ShowTeacherDetails(object sender, EventArgs e)
        {
            if (_currentTeacher != null)
            {
                string details = $"تفاصيل المدرس:\n\n" +
                               $"الاسم الكامل: {_currentTeacher.FirstName} {_currentTeacher.LastName}\n" +
                               $"تاريخ الميلاد: {_currentTeacher.DateOfBirth?.ToString("yyyy/MM/dd") ?? "غير محدد"}\n" +
                               $"الراتب: {_currentTeacher.Salary?.ToString("C2") ?? "غير محدد"}\n" +
                               $"المؤهل العلمي: {_currentTeacher.EducationDegree ?? "غير محدد"}\n" +
                               $"المادة الدراسية: {_currentTeacher.TeachingSubject ?? "غير محدد"}\n" +
                               $"تاريخ بدء العمل: {_currentTeacher.StartWorkingDate?.ToString("yyyy/MM/dd") ?? "غير محدد"}\n" +
                               $"عدد الإجازات: {_currentTeacher.NumberOfVacations?.ToString() ?? "غير محدد"}\n" +
                               $"رقم الهاتف: {_currentTeacher.PhoneNumber ?? "غير محدد"}\n" +
                               $"البريد الإلكتروني: {_currentTeacher.Email ?? "غير محدد"}\n" +
                               $"الحالة الاجتماعية: {_currentTeacher.SocialStatus ?? "غير محدد"}";

                MessageBox.Show(details, "تفاصيل المدرس",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_DeleteTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}