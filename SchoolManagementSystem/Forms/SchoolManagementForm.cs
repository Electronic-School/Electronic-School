using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
    public partial class SchoolManagement : Form
    {
        private Button currentActiveButton;

        public SchoolManagement()
        {
            InitializeComponent();
            // Bind to the SizeChanged event to handle responsive positioning of the sidebar logout button.
            this.SizeChanged += SchoolManagement_SizeChanged;
        }


        private void ApplyNavigationButtonStyle(Button b)
        {
            b.ForeColor = Color.WhiteSmoke;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Padding = new Padding(48, 0, 0, 0); // space for icon at left
            b.BackColor = Color.FromArgb(40, 40, 40);
            b.ImageAlign = ContentAlignment.MiddleLeft;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
        }


        private void InitializeNavigationButtons()
        {
            ApplyNavigationButtonStyle(btnDashboard);
            ApplyNavigationButtonStyle(btnStudents);
            ApplyNavigationButtonStyle(btnTeachers);
            ApplyNavigationButtonStyle(btnCourses);
            ApplyNavigationButtonStyle(btnLocations);
            ApplyNavigationButtonStyle(btnLogout);
        }


        private void UpdateSidebarLogoutButtonPosition()
        {
            int buttonTop = this.pnlSidebar.Height - btnLogout.Height - 12;
            btnLogout.Location = new Point(12, buttonTop);
        }


        private void SchoolManagement_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeNavigationButtons();
                lblUser.Text = $"User: Admin (Role: Head Administrator)";
                UpdateSidebarLogoutButtonPosition();

                LoadUserControl("DashboardControl");
                SetActiveButton(btnDashboard);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A critical error occurred during application startup: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SchoolManagement_SizeChanged(object sender, EventArgs e)
        {
            UpdateSidebarLogoutButtonPosition();
        }


        private void navButton_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton != null && currentActiveButton != clickedButton)
            {
                SetActiveButton(clickedButton);
                string? controlName = clickedButton.Tag?.ToString();
                if (!string.IsNullOrEmpty(controlName))
                {
                    LoadUserControl(controlName);
                }
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "هل أنت متأكد أنك تريد تسجيل الخروج؟ سيتم إغلاق التطبيق.",
                "تأكيد تسجيل الخروج",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ----------------------------------------------------------------------
        // منطق التنقل والواجهة
        // ----------------------------------------------------------------------

        /// <summary>
        /// يضبط الحالة النشطة بصرياً للزر المحدد.
        /// </summary>
        private void SetActiveButton(Button activeButton)
        {

            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(40, 40, 40);
                currentActiveButton.ForeColor = Color.WhiteSmoke;
            }

            currentActiveButton = activeButton;
            currentActiveButton.BackColor = Color.FromArgb(32, 150, 110);
            currentActiveButton.ForeColor = Color.White;
        }

        /// <summary>
        /// يحمل التحكم المحدد (UserControl) ديناميكياً في منطقة المحتوى.
        /// </summary>
        private void LoadUserControl(string controlName)
        {
            pnlContent.Controls.Clear();
            UserControl? newControl = null;

            try
            {
                switch (controlName)
                {
                    case "DashboardControl":
                        newControl = new DashboardControl();
                        break;
                    case "AddStudentControl":
                        newControl = new AddStudentControl();
                        break;
                    case "AddTeacherControl":
                        newControl = new AddTeacherControl();
                        break;
                    case "CourseManagementControl":
                        newControl = new CourseManagementControl();
                        break;
                    case "LocationsControl":
                        newControl = new LocationsControl();
                        break;
                    default:
                        Label errorLabel = new Label
                        {
                            Text = $"Control '{controlName}' not implemented.",
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                            ForeColor = Color.Red
                        };
                        pnlContent.Controls.Add(errorLabel);
                        return;
                }

                if (newControl != null)
                {
                    newControl.Dock = DockStyle.Fill;
                    pnlContent.Controls.Add(newControl);
                    newControl.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load control '{controlName}': {ex.Message}", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ShowForm<EmployeeForm>();
        }
    }
}