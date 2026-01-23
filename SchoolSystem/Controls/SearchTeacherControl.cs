using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class SearchTeacherControl : UserControl
    {
        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185);

        public SearchTeacherControl()
        {
            InitializeComponent();
            ApplyModernDesign();
        }

        private void ApplyModernDesign()
        {
            if (btnSearch != null)
            {
                btnSearch.BackColor = PrimaryColor;
                btnSearch.ForeColor = Color.White;
                btnSearch.FlatStyle = FlatStyle.Flat;
                btnSearch.FlatAppearance.BorderSize = 0;
            }

            if (btnClear != null)
            {
                btnClear.BackColor = Color.FromArgb(149, 165, 166);
                btnClear.ForeColor = Color.White;
                btnClear.FlatStyle = FlatStyle.Flat;
                btnClear.FlatAppearance.BorderSize = 0;
            }

            if (pnlResult != null)
                pnlResult.Visible = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PerformSearch()
        {
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a Teacher ID or Name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new SchoolDbContext())
                {
                    Teacher teacher = null;

                    if (int.TryParse(query, out int teacherId))
                    {
                        teacher = context.Teachers
                            .Include(t => t.Location).ThenInclude(l => l.City)
                            .Include(t => t.Location).ThenInclude(l => l.Country)
                            .FirstOrDefault(t => t.TeacherId == teacherId);
                    }
                    else
                    {
                        teacher = context.Teachers
                            .Include(t => t.Location).ThenInclude(l => l.City)
                            .Include(t => t.Location).ThenInclude(l => l.Country)
                            .FirstOrDefault(t => t.FirstName.Contains(query) || t.LastName.Contains(query));
                    }

                    if (teacher != null)
                    {
                        PopulateTeacherData(teacher);
                    }
                    else
                    {
                        pnlResult.Visible = false;
                        MessageBox.Show("No teacher found with this ID or Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for teacher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTeacherData(Teacher teacher)
        {
            lblValueID.Text = teacher.TeacherId.ToString();
            lblValueName.Text = $"{teacher.FirstName} {teacher.LastName}";
            lblValueSubject.Text = teacher.TeachingSubject;
            lblValueDegree.Text = teacher.EducationDegree;

            lblValuePhone.Text = teacher.PhoneNumber;
            lblValueEmail.Text = teacher.Email;

            lblValueSalary.Text = teacher.Salary.HasValue ? $"{teacher.Salary:N2}" : "N/A";

            lblValueDate.Text = teacher.StartWorkingDate.HasValue
            ? teacher.StartWorkingDate.Value.ToShortDateString()
            : "N/A";

            if (teacher.Location != null)
            {
                string country = teacher.Location.Country?.CountryName ?? "";
                string city = teacher.Location.City?.CityName ?? "";
                lblValueAddress.Text = $"{teacher.Location.Street}, {teacher.Location.BuildingNo}, {city}, {country}";
            }
            else
            {
                lblValueAddress.Text = "No Location Assigned";
            }

            pnlResult.Visible = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            pnlResult.Visible = false;
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

