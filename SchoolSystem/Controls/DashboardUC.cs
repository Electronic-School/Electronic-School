using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolSystem.Controls
{
    public partial class DashboardUC : UserControl
    {
        private readonly SchoolDbContext _context;

        public DashboardUC()
        {
            InitializeComponent();
            _context = new SchoolDbContext();
            LoadDashboardData();
        }

        private async void LoadDashboardData()
        {
            try
            {
                // إظهار مؤشر التحميل
                Cursor = Cursors.WaitCursor;
                lblStudentCount.Text = "جاري التحميل...";
                lblTeacherCount.Text = "جاري التحميل...";
                lblClassesCount.Text = "جاري التحميل...";

                // جلب البيانات من قاعدة البيانات بشكل غير متزامن
                int totalStudents = await GetTotalStudentsAsync();
                int totalTeachers = await GetTotalTeachersAsync();
                int totalClasses = await GetTotalClassesAsync();

                // تحديث Labels
                lblStudentCount.Text = totalStudents.ToString("N0"); // تنسيق بأفاصل الآلاف
                lblTeacherCount.Text = totalTeachers.ToString("N0");
                lblClassesCount.Text = totalClasses.ToString("N0");

                // تحديث التلميحات (ToolTips) إذا كانت موجودة
                //if (toolTip1 != null)
                //{
                //    toolTip1.SetToolTip(lblStudentCount, $"إجمالي عدد الطلاب: {totalStudents:N0}");
                //    toolTip1.SetToolTip(lblTeacherCount, $"إجمالي عدد المدرسين: {totalTeachers:N0}");
                //    toolTip1.SetToolTip(lblClassesCount, $"إجمالي عدد الفصول: {totalClasses:N0}");
                //}
            }
            catch (Exception ex)
            {
                // في حالة حدوث خطأ، عرض قيم افتراضية
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}\nسيتم عرض أرقام افتراضية.",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblStudentCount.Text = "0";
                lblTeacherCount.Text = "0";
                lblClassesCount.Text = "0";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async Task<int> GetTotalStudentsAsync()
        {
            try
            {
                // جلب عدد الطلاب من قاعدة البيانات
                return await _context.Students.CountAsync();
            }
            catch
            {
                return 0; // في حالة الخطأ، إرجاع 0
            }
        }

        private async Task<int> GetTotalTeachersAsync()
        {
            try
            {
                // جلب عدد المدرسين من قاعدة البيانات
                return await _context.Teachers.CountAsync();
            }
            catch
            {
                return 0; // في حالة الخطأ، إرجاع 0
            }
        }

        private async Task<int> GetTotalClassesAsync()
        {
            try
            {
                // إذا كان لديك جدول للفصول (مثل Courses أو Classes)
                // يمكنك استخدامه. وإلا، إرجاع 0 أو حساب تقريبي

                // مثال: إذا كان لديك جدول Courses
                // return await _context.Courses.CountAsync();

                // أو حساب تقريبي بناءً على المستويات
                var studentLevels = await _context.StudentLevels.CountAsync();
                return studentLevels * 3; // مثال: 3 فصول لكل مستوى
            }
            catch
            {
                return 0; // في حالة الخطأ، إرجاع 0
            }
        }

        // دالة لتحديث البيانات يدوياً (يمكن استدعاؤها من زر تحديث)
        public void RefreshData()
        {
            LoadDashboardData();
        }

        // تنظيف الموارد عند التخلص من الـ UserControl
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        // يمكنك إضافة زر تحديث في الواجهة واستدعاء هذه الدالة
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        // إذا أردت تحديث تلقائي كل فترة (اختياري)
        private void timerAutoRefresh_Tick(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}