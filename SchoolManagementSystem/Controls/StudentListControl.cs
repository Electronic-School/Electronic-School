using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controls
{
    public partial class ListStudentsControl : UserControl
    {
        public ListStudentsControl()
        {
            InitializeComponent();
            LoadStudents();
        }

        public void LoadStudents()
        {
            try
            {
                using var db = new SchoolDbContext();
                var students = db.Students
                    .Select(s => new
                    {
                        s.STUDENTID,
                        الاسم = s.FIRSTNAME + " " + s.LASTNAME,
                        الموقع = s.LOCATIONID,
                        الأب = s.ParentId
                    })
                    .ToList();

                dataGridView.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}