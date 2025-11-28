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
using System.Windows.Forms;
using SchoolManagementSystem.Controls;

namespace SchoolManagementSystem.Forms
{
    public partial class TeacherForm : Form
    {
        private UC_ListTeachers listTeachersControl;
        private UC_AddTeacher addTeacherControl;
        private UC_UpdateTeacher updateTeacherControl;
        private UC_DeleteTeacher deleteTeacherControl;

        public TeacherForm()
        {
            InitializeComponent();
            InitializeControls();
            ShowListTeachers();
        }

        private void InitializeControls()
        {
            listTeachersControl = new UC_ListTeachers();
            addTeacherControl = new UC_AddTeacher();
            updateTeacherControl = new UC_UpdateTeacher();
            deleteTeacherControl = new UC_DeleteTeacher();

            // جعل جميع الكونترولات بحجم البانل الرئيسي
            listTeachersControl.Dock = DockStyle.Fill;
            addTeacherControl.Dock = DockStyle.Fill;
            updateTeacherControl.Dock = DockStyle.Fill;
            deleteTeacherControl.Dock = DockStyle.Fill;

            // أحداث للتحديث التلقائي
            addTeacherControl.OnTeacherAdded += (s, e) => ShowListTeachers();
            updateTeacherControl.OnTeacherUpdated += (s, e) => ShowListTeachers();
            deleteTeacherControl.OnTeacherDeleted += (s, e) => ShowListTeachers();
        }

        private void ClearMainPanel()
        {
            mainPanel.Controls.Clear();
        }

        private void ShowListTeachers()
        {
            ClearMainPanel();
            listTeachersControl.LoadTeachers(); // تحديث البيانات
            mainPanel.Controls.Add(listTeachersControl);
            lblTitle.Text = "قائمة المدرسين";
        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            ShowListTeachers();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            mainPanel.Controls.Add(addTeacherControl);
            lblTitle.Text = "إضافة مدرس جديد";
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            mainPanel.Controls.Add(updateTeacherControl);
            lblTitle.Text = "تعديل بيانات مدرس";
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            mainPanel.Controls.Add(deleteTeacherControl);
            lblTitle.Text = "حذف مدرس";
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}