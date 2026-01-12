using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System.Threading.Tasks;
using SchoolSystem.Controls;

namespace SchoolSystem.Controls
{
    public partial class TeacherGridUC : UserControl
    {
        private const string connectionString = "Server=.;Database=SchoolManagementDB;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true;";


        public TeacherGridUC()
        {
            InitializeComponent();
            this.Load += TeacherGridUC_Load;

            //btnAdd.Click += btnAdd_Click;
            //btnEdit.Click += btnEdit_Click;
            //btnDelete.Click += btnDelete_Click;
        }

        private async void TeacherGridUC_Load(object sender, EventArgs e)
        {
            await LoadTeachersData();
        }

        private async Task LoadTeachersData()
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<SchoolDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var context = new SchoolDbContext(optionsBuilder.Options))
                {
                    var teachers = await context.Teachers
                        .Include(t => t.Location)
                        .Where(t => !t.FirstName.Contains("Default") && !t.LastName.Contains("Teacher")) // هنا الشرط
                        .Select(t => new
                        {
                            t.TeacherId,
                            Name = t.FirstName + " " + t.LastName,
                            t.DateOfBirth,
                            t.Salary,
                            Education = t.EducationDegree,
                            Subject = t.TeachingSubject,
                            t.StartWorkingDate,
                            Vacations = t.NumberOfVacations,
                            Phone = t.PhoneNumber,
                            Email = t.Email,
                            Status = t.SocialStatus
                        })
                        .ToListAsync();

                    dgvTeachers.DataSource = teachers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load teachers:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event EventHandler<int> EditClicked;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                int teacherId = (int)dgvTeachers.SelectedRows[0].Cells["TeacherId"].Value;

                EditClicked?.Invoke(this, teacherId);
            }
            else
            {
                MessageBox.Show("Please select a teacher to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected teacher record?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int teacherId = (int)dgvTeachers.SelectedRows[0].Cells["TeacherId"].Value;

                    MessageBox.Show($"Deleting teacher with ID: {teacherId}...", "Action");
                    // await DeleteTeacher(teacherId); 
                    // await LoadTeachersData();
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}