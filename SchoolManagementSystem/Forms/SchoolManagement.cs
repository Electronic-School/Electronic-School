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
        // ----------------------------------------------------------------------
        // Event Handlers
        // ----------------------------------------------------------------------

        /// <summary>
        /// Handles the form load event for initial setup.
        /// </summary>
        private void SchoolManagement_Load(object sender, EventArgs e)
        {
            // Initial setup on form load
            try
            {
                // Set initial user info (This should be loaded from authentication in a real app)
                lblUser.Text = $"User: Admin (Role: Head Administrator)";

                // Set the correct location for the sidebar logout button immediately
                UpdateSidebarLogoutButtonPosition();

                // Load the default screen (Dashboard) and mark the button as active
                LoadUserControl("DashboardControl");
                SetActiveButton(btnDashboard);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A critical error occurred during application startup: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles form resizing to keep the Logout button correctly positioned at the bottom of the sidebar.
        /// </summary>
        private void SchoolManagement_SizeChanged(object sender, EventArgs e)
        {
            UpdateSidebarLogoutButtonPosition();
        }

        /// <summary>
        /// Adjusts the position of the sidebar Logout button to anchor it to the bottom.
        /// </summary>
        private void UpdateSidebarLogoutButtonPosition()
        {
            // Position the Logout button 12 pixels from the bottom of the sidebar panel.
            int buttonTop = this.pnlSidebar.Height - btnLogout.Height - 12;
            btnLogout.Location = new Point(12, buttonTop);
        }

        /// <summary>
        /// Handles clicks on the sidebar navigation buttons.
        /// </summary>
        private void navButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && currentActiveButton != clickedButton)
            {
                // 1. Highlight the newly clicked button
                SetActiveButton(clickedButton);

                // 2. Load the associated User Control
                string controlName = clickedButton.Tag?.ToString();
                if (!string.IsNullOrEmpty(controlName))
                {
                    LoadUserControl(controlName);
                }
            }
        }

        /// <summary>
        /// Handles the logout action from either the sidebar or the header button.
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // In a real application, this would handle session cleanup and potentially show a login screen.
            DialogResult result = MessageBox.Show("Are you sure you want to log out of the system?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Simple exit: Closes the main form and ends the application.
                this.Close();
            }
        }

        // ----------------------------------------------------------------------
        // Navigation / UI Logic
        // ----------------------------------------------------------------------

        /// <summary>
        /// Visually sets the active state for the selected navigation button.
        /// </summary>
        private void SetActiveButton(Button activeButton)
        {
            // Reset the previous active button's style
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(40, 40, 40); // Inactive color
                currentActiveButton.ForeColor = Color.WhiteSmoke;
            }

            // Set the new active button's style
            currentActiveButton = activeButton;
            currentActiveButton.BackColor = Color.FromArgb(32, 150, 110); // Active (Accent) color
            currentActiveButton.ForeColor = Color.White;
        }

        /// <summary>
        /// Dynamically loads the requested UserControl into the pnlContent area.
        /// </summary>
        private void LoadUserControl(string controlName)
        {
            // Clear existing controls from the content panel
            pnlContent.Controls.Clear();
            UserControl newControl = null;

            // Mapping control names (from button tags) to their actual instances
            try
            {
                // Use a dictionary or switch-case to map strings to types/instances
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

                // Add the new control to the content panel
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
    }
}
