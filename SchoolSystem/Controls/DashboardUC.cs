using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            // ⚠️ ملاحظة: هذا مجرد كود افتراضي (Mock Data).
            // في مشروع حقيقي، ستقوم هنا باستدعاء دالة من طبقة البيانات (DAL)
            // لجلب الأعداد الحقيقية من قاعدة البيانات.

            int totalStudents = 1250;
            int totalTeachers = 85;
            int totalClasses = 50;

            // تحديث Labels
            lblStudentCount.Text = totalStudents.ToString();
            lblTeacherCount.Text = totalTeachers.ToString();
            lblClassesCount.Text = totalClasses.ToString();
        }
    }
}
