using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Controls
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            LoadDashboardData();
            InitializeComponent(EventArgs.Empty);   
        }

        private void InitializeComponent(EventArgs e)
        {
            this.SuspendLayout();
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Padding = new Padding(20);

            // Title Label
            Label lblTitle = new Label();
            lblTitle.Text = "Welcome to the School Management Dashboard";
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
            this.Controls.Add(lblTitle);

            // Subtitle
            Label lblSubtitle = new Label();
            lblSubtitle.Text = "Quick overview of the system metrics.";
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(20, 70);
            this.Controls.Add(lblSubtitle);

            // Info Panel (Placeholder for Metrics)
            Panel infoPanel = new Panel();
            infoPanel.Size = new Size(800, 200);
            infoPanel.Location = new Point(20, 120);
            infoPanel.BackColor = Color.White;
            infoPanel.BorderStyle = BorderStyle.FixedSingle;
            infoPanel.Padding = new Padding(15);

            Label lblInfo = new Label();
            lblInfo.Name = "metricsLabel"; // Important for LoadDashboardData to find it
            lblInfo.Text = "System Status: Online\nData Last Updated: [Fetching...]";
            lblInfo.Font = new Font("Segoe UI", 14F);
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.TextAlign = ContentAlignment.TopLeft;
            infoPanel.Controls.Add(lblInfo);

            this.Controls.Add(infoPanel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadDashboardData()
        {
            // Find the Label inside the Info Panel to display metrics
            var metricLabelControl = this.Controls.Find("metricsLabel", true);
            if (metricLabelControl.Length > 0 && metricLabelControl[0] is Label infoLabel)
            {
                // Placeholder values for demonstration. 
                // In a complete system, these would be retrieved using the DbContext.
                int studentCount = 1250;
                int teacherCount = 65;
                int courseCount = 48;

                infoLabel.Text = $"System Status: Online\n" +
                                 $"Data Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n" +
                                 $"Total Students: {studentCount}\n" +
                                 $"Total Teachers: {teacherCount}\n" +
                                 $"Active Courses: {courseCount}";
            }
        }

    }
}
