using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controls
{
    public partial class UC_ListTeachers : UserControl
    {
        public UC_ListTeachers()
        {
            InitializeComponent();
            LoadTeachers();
        }

        public void LoadTeachers()
        {
            try
            {
                using var db = new AppDbContext();
                var teachers = db.Teachers
                    .Select(t => new
                    {
                        t.ID,
                        الاسم = t.FirstName + " " + t.LastName,
                        t.DateOfBirth,
                        t.Salary,
                        المؤهل = t.EducationDegree,
                        المادة = t.TeachingSubject,
                        t.StartWorkingDate,
                        إجازات = t.NumberOfVacations,
                        الهاتف = t.PhoneNumber,
                        البريد = t.Email,
                        الحالة = t.SocialStatus
                    })
                    .ToList();

                dataGridView.DataSource = teachers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }
    }
}