using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Data;
using System.Windows.Forms.VisualStyles;

namespace SchoolManagementSystem.Forms
{
    public partial class CourseManagementForm : Form
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();
        public CourseManagementForm()
        {
            InitializeComponent();
            // wire events if not wired in designer
            txtSearch.TextChanged += async (_, __) => await LoadCoursesAsync();
            cmbLocationFilter.SelectedIndexChanged += async (_, __) => await LoadCoursesAsync();
            dgvCourses.SelectionChanged += (_, __) => UpdateActionButtons();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private async void CourseManagementForm_Load(object? sender, EventArgs e)
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
                // support the anonymous "All Locations" item
                var type = cmbLocationFilter.SelectedItem.GetType();
                var prop = type.GetProperty("LocationId");
                if (prop != null) selectedLocationId = (int)prop.GetValue(cmbLocationFilter.SelectedItem)!;
            }

            var query = _context.Courses
                .Include(c => c.Teacher)
                .Include(c => c.Location)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(c =>
                    EF.Functions.Like(c.Name.ToLower(), $"%{q}%") ||
                    (c.Teacher != null && EF.Functions.Like((c.Teacher.FirstName + " " + c.Teacher.LastName).ToLower(), $"%{q}%"))
                );
            }

            if (selectedLocationId != 0)
                query = query.Where(c => c.LocationId == selectedLocationId);

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

        private void ConfigureGridColumns()
        {
            dgvCourses.AutoGenerateColumns = true;
            dgvCourses.Columns["CourseId"].Visible = false;
            dgvCourses.Columns["CourseName"].HeaderText = "Course Name";
            dgvCourses.Columns["TeacherName"].HeaderText = "Teacher";
            dgvCourses.Columns["LocationName"].HeaderText = "Location";
            dgvCourses.Columns["DurationHours"].HeaderText = "Duration (hrs)";
            dgvCourses.Columns["StartDate"].HeaderText = "Start Date";
            dgvCourses.Columns["Price"].HeaderText = "Price";
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.MultiSelect = true;
        }

        private void UpdateActionButtons()
        {
            bool hasSelection = dgvCourses.SelectedRows.Count > 0;
            btnEdit.Enabled = dgvCourses.SelectedRows.Count == 1;
            btnDelete.Enabled = hasSelection;
        }

        private async void BtnAdd_Click(object? sender, EventArgs e)
        {
            using var f = new AddEditCourseForm();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCoursesAsync();
            }
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count != 1) return;
            int courseId = (int)dgvCourses.SelectedRows[0].Cells["CourseId"].Value!;
            using var f = new AddEditCourseForm(courseId);
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCoursesAsync();
            }
        }

        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0) return;
            var ids = dgvCourses.SelectedRows
                .OfType<DataGridViewRow>()
                .Select(r => (int)r.Cells["CourseId"].Value!)
                .ToArray();

            var confirm = MessageBox.Show($"Are you sure you want to delete {ids.Length} course(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            var toDelete = await _context.Courses.Where(c => ids.Contains(c.CourseId)).ToListAsync();
            _context.Courses.RemoveRange(toDelete);
            await _context.SaveChangesAsync();
            await LoadCoursesAsync();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _context.Dispose();
        }
    }
}
