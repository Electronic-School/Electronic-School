using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
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
    public partial class CourseManagementControl : UserControl
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();
        public CourseManagementControl()
        {
            InitializeComponent();
            txtSearch.TextChanged += async (_, __) => await LoadCoursesAsync();
            cmbLocationFilter.SelectedIndexChanged += async (_, __) => await LoadCoursesAsync();
            dgvCourses.SelectionChanged += (_, __) => UpdateActionButtons();

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            this.Load += CourseManagementControl_Load;
        }

        private async void CourseManagementControl_Load(object? sender, EventArgs e)
        {
            await LoadLocationFilterAsync();
            await LoadCoursesAsync();
            UpdateActionButtons();
        }

        private async Task LoadLocationFilterAsync()
        {
            var locations = await _context.Locations
                .AsNoTracking()
                .OrderBy(l => l.LocationName)
                .ToListAsync();

            cmbLocationFilter.DisplayMember = "LocationName";
            cmbLocationFilter.ValueMember = "LocationId";
            cmbLocationFilter.Items.Clear();

            cmbLocationFilter.Items.Add(new { LocationId = 0, LocationName = "All Locations" }!);
            foreach (var loc in locations) cmbLocationFilter.Items.Add(loc);
            cmbLocationFilter.SelectedIndex = 0;
        }

        private async Task LoadCoursesAsync()
        {
            string q = txtSearch.Text.Trim().ToLower();
            int selectedLocationId = 0;

            if (cmbLocationFilter.SelectedItem != null)
            {
                var type = cmbLocationFilter.SelectedItem.GetType();
                var prop = type.GetProperty("LocationId");
                if (prop != null) selectedLocationId = (int)prop.GetValue(cmbLocationFilter.SelectedItem)!;
            }

            var query = _context.Courses
                //  Eager Loading
                .Include(c => c.Teacher)
                .Include(c => c.Location)
                .AsNoTracking()
                .AsQueryable();

            // تطبيق البحث (Search)
            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(c =>
                    EF.Functions.Like(c.Name.ToLower(), $"%{q}%") ||
                    (c.Teacher != null && EF.Functions.Like((c.Teacher.FirstName + " " + c.Teacher.LastName).ToLower(), $"%{q}%"))
                );
            }

            // تطبيق التصفية (Filter)
            if (selectedLocationId != 0)
                query = query.Where(c => c.LocationId == selectedLocationId);

            // الإسقاط (Projection) واختيار الأعمدة المطلوبة للعرض
            var list = await query
                .OrderBy(c => c.StartDate)
                .Select(c => new
                {
                    c.CourseId,
                    CourseName = c.Name,
                    TeacherName = c.Teacher != null ? c.Teacher.FirstName + " " + c.Teacher.LastName : string.Empty,
                    LocationName = c.Location != null ? c.Location.LocationName : string.Empty,
                    c.DurationHours,
                    StartDate = c.StartDate,
                    c.Price
                })
                .ToListAsync();

            dgvCourses.DataSource = list;
            ConfigureGridColumns();
        }

        // إعداد وتنسيق أعمدة جدول البيانات
        private void ConfigureGridColumns()
        {
            dgvCourses.AutoGenerateColumns = true;
            dgvCourses.Columns["CourseId"].Visible = false; // إخفاء معرف الدورة
            dgvCourses.Columns["CourseName"].HeaderText = "اسم الدورة";
            dgvCourses.Columns["TeacherName"].HeaderText = "المعلم المسؤول";
            dgvCourses.Columns["LocationName"].HeaderText = "الموقع";
            dgvCourses.Columns["DurationHours"].HeaderText = "المدة (ساعة)";
            dgvCourses.Columns["StartDate"].HeaderText = "تاريخ البدء";
            dgvCourses.Columns["Price"].HeaderText = "السعر";

            // تنسيق الجدول
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.MultiSelect = true;
        }

        // تحديث حالة أزرار الإجراءات (تفعيل/تعطيل)
        private void UpdateActionButtons()
        {
            bool hasSelection = dgvCourses.SelectedRows.Count > 0;
            btnEdit.Enabled = dgvCourses.SelectedRows.Count == 1; // التعديل يتطلب اختيار سطر واحد فقط
            btnDelete.Enabled = hasSelection; // الحذف يتطلب اختيار سطر واحد أو أكثر
        }

        // ---- دوال الإجراءات (CRUD) ----

        private async void BtnAdd_Click(object? sender, EventArgs e)
        {
            // فتح نموذج الإضافة والتعديل كنموذج منبثق (Modal)
            // (يجب أن يتم تعريف AddEditCourseForm في مكان آخر)
            using var f = new Forms.AddEditCourseForm();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCoursesAsync(); // إعادة تحميل البيانات بعد الإضافة الناجحة
            }
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count != 1) return;

            // استخراج معرف الدورة من الصف المحدد
            int courseId = (int)dgvCourses.SelectedRows[0].Cells["CourseId"].Value!;
            using var f = new Forms.AddEditCourseForm(courseId);
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCoursesAsync(); // إعادة تحميل البيانات بعد التعديل الناجح
            }
        }

        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0) return;

            // جمع معرفات الدورات المحددة للحذف المتعدد
            var ids = dgvCourses.SelectedRows
                .OfType<DataGridViewRow>()
                .Select(r => (int)r.Cells["CourseId"].Value!)
                .ToArray();

            // رسالة تأكيد (يُفضل استخدام واجهة تأكيد مخصصة بدلاً من MessageBox في تطبيقات الإنتاج)
            var confirm = MessageBox.Show($"هل أنت متأكد من حذف {ids.Length} دورة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            // تنفيذ الحذف باستخدام EF Core
            var toDelete = await _context.Courses.Where(c => ids.Contains(c.CourseId)).ToListAsync();
            _context.Courses.RemoveRange(toDelete);
            await _context.SaveChangesAsync();

            await LoadCoursesAsync();
        }

        // تنظيف موارد الـ DbContext عند إغلاق عنصر التحكم
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
