using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;

namespace SchoolSystem.Controls
{
    public partial class ShowAllStudentsControl : UserControl
    {
        // ألوان التصميم
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185); // أزرق داكن
        private readonly Color SecondaryColor = Color.FromArgb(236, 240, 241); // رمادي فاتح

        public ShowAllStudentsControl()
        {
            InitializeComponent();
            ApplyModernDesign();
            LoadStudents();
        }

        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;
            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.EnableHeadersVisualStyles = false;

            // رأس الجدول
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStudents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudents.ColumnHeadersHeight = 45;

            // صفوف الجدول
            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 247, 255);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudents.RowTemplate.Height = 40;
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = SecondaryColor;

            // خصائص الجدول
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.GridColor = Color.FromArgb(224, 224, 224);

            // إضافة حدود ناعمة
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // التمرير السلس
            dgvStudents.ScrollBars = ScrollBars.Both;
        }

        private void LoadStudents()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (var context = new SchoolDbContext())
                {
                    var students = context.Students
                        .Include(s => s.Location)
                            .ThenInclude(l => l.City)
                        .Include(s => s.Location)
                            .ThenInclude(l => l.Country)
                        .Include(s => s.Parent)
                        .Select(s => new
                        {
                            s.StudentId,
                            s.FirstName,
                            s.LastName,
                            DateOfBirth = s.DateOfBirth.HasValue ? s.DateOfBirth.Value.ToString("dd/MM/yyyy") : "",
                            Location = s.Location.Street + ", " + s.Location.BuildingNo + ", " + s.Location.City.CityName + ", " + s.Location.Country.CountryName,
                            ParentName = s.Parent.FirstName + " " + s.Parent.LastName,
                            s.Parent.PhoneNumber,
                            s.Parent.Email
                        })
                        .ToList();

                    dgvStudents.DataSource = students;

                    // تخصيص تنسيق الأعمدة
                    CustomizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load students:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void CustomizeColumns()
        {
            if (dgvStudents.Columns.Count > 0)
            {
                // إعادة تسمية الأعمدة
                dgvStudents.Columns["StudentId"].HeaderText = "ID";
                dgvStudents.Columns["FirstName"].HeaderText = "First Name";
                dgvStudents.Columns["LastName"].HeaderText = "Last Name";
                dgvStudents.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dgvStudents.Columns["Location"].HeaderText = "Address";
                dgvStudents.Columns["ParentName"].HeaderText = "Parent Name";
                dgvStudents.Columns["PhoneNumber"].HeaderText = "Parent Phone";
                dgvStudents.Columns["Email"].HeaderText = "Parent Email";

                // تنسيق أعمدة محددة
                //dgvStudents.Columns["StudentsId"].Width = 70;
                //dgvStudents.Columns["StudentsId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //dgvStudents.Columns["DateOfBirth"].Width = 100;
                //dgvStudents.Columns["PhoneNumber"].Width = 120;

                // توسيع عمود العنوان
                //dgvStudents.Columns["Location"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}