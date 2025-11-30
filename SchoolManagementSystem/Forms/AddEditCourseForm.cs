using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Forms
{
    public partial class AddEditCourseForm : Form
    {

        private readonly SchoolDbContext _context = new SchoolDbContext();
        private int _courseId = 0;

        public AddEditCourseForm()
        {
            InitializeComponent();
            this.Text = "إضافة دورة جديدة";

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(7);
        }

        public AddEditCourseForm(int courseId) : this()
        {
            _courseId = courseId;
            this.Text = "تعديل بيانات الدورة";
        }

        private async void AddEditCourseForm_Load(object sender, EventArgs e)
        {
            await LoadRelatedDataAsync();
            if(_courseId > 0)
            {
                await LoadCourseDataAsync();
            }
        }

        private async Task LoadRelatedDataAsync()
        {
            try
            {
                // we load teacher data and linked with hte cmbTeacher
                var teachers = await _context.Teachers
                    .OrderBy(t => t.FirstName)
                    .Select(t => new
                    {
                        TeacherId = t.TeacherId,
                        FullName = t.FirstName + " " + t.LastName
                    })
                    .AsNoTracking()
                    .ToListAsync();
                cmbTeacher.DataSource = teachers;
                cmbTeacher.DisplayMember = "FullName";
                cmbTeacher.ValueMember = "TeacherId";

                //load curriculum data and linked with cmbCurriculum
                var curricula = await _context.Curriculum
                    .Select(c => new
                    {
                        CurriculumId = c.Id,
                        CurriculumName = c.Name
                    })
                    .AsNoTracking()
                    .ToListAsync();

                cmbCurriculum.DataSource = curricula;
                cmbCurriculum.DisplayMember = "CurriculumName";
                cmbCurriculum.ValueMember = "CurriculumId";

                if (teachers.Any())
                {
                    cmbTeacher.SelectedIndex = 0;
                }
                if (curricula.Any())
                {
                    cmbCurriculum.SelectedIndex = 0;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"فشل تحميل البيانات المترابطة: {ex.Message}", "خطأ في التحميل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCourseDataAsync()
        {
            var course = await _context.Courses
                .FirstOrDefaultAsync(c => c.CourseId == _courseId);

            if (course == null)
            {
                MessageBox.Show("لم يتم العثور على بيانات الدورة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtName.Text = course.Name;
            txtDescription.Text = course.Description ?? string.Empty;

            if (course.StartDate.HasValue)
            {
                dtpStartDate.Value = course.StartDate.Value;
            }
            else
            {
                dtpStartDate.Value = DateTime.Today;
            }
            if (course.EndDate.HasValue)
            {
                dtpEndDate.Value = course.EndDate.Value;
            }
            else
            {
                dtpEndDate.Value = DateTime.Today.AddDays(7);
            }

            if (course.TeacherId.HasValue)
            {
                cmbTeacher.SelectedValue = course.TeacherId.Value;
            }

            if (course.CurriculumId.HasValue)
            {
                cmbCurriculum.SelectedValue = course.CurriculumId.Value;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Course? course;
            if (_courseId == 0)
            {
                course = new Course();
                _context.Courses.Add(course);
            }
            else
            {
                course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == _courseId);
                if (course == null)
                {
                    MessageBox.Show("تعذر العثور على الدورة الأصلية للتعديل.", "خطأ قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            course.Name = txtName.Text.Trim();
            course.Description = txtDescription.Text.Trim();
            course.StartDate = dtpStartDate.Value.Date;
            course.EndDate = dtpEndDate.Value.Date;

            course.TeacherId = (int)cmbTeacher.SelectedValue!;
            course.CurriculumId = (int)cmbCurriculum.SelectedValue!;

            try
            {
                await _context.SaveChangesAsync();
                MessageBox.Show("تم حفظ بيانات الدورة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ البيانات: {ex.InnerException?.Message ?? ex.Message}", "خطأ قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool ValidateInput()
        {
            if(string.IsNullOrWhiteSpace(txtName.Text)|| string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم ووصف الدورة.", "تحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (cmbTeacher.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المعلم المسؤول.", "تحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTeacher.Focus();
                return false;
            }
            if(cmbCurriculum.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المنهج الدراسي.", "تحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCurriculum.Focus();
                return false;
            }
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                MessageBox.Show("تاريخ الانتهاء يجب أن يكون بعد أو مساويًا لتاريخ البدء.", "تحقق من التاريخ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (_context != null))
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
