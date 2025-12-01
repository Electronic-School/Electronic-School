using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem.Controls
{
    partial class DashboardControl : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMetrics;
        // تم إزالة تعريفات pnlStudents, pnlTeachers, pnlCourses, pnlLocations
        // لأنها الآن يتم إنشاؤها ديناميكياً في ملف DashboardControl.cs

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMetrics = new System.Windows.Forms.Panel();

            // تم إزالة تهيئة pnlStudents, pnlTeachers, pnlCourses, pnlLocations

            // Dashboard Control Setup
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1200, 700);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Padding = new Padding(20);
            this.Load += new System.EventHandler(this.DashboardControl_Load); // ربط حدث التحميل

            // lblTitle
            this.lblTitle.Text = "Dashboard - About The System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(this.lblTitle);

            // pnlMetrics (Container for Stat Cards)
            // هذا هو العنصر الوحيد الذي سيتم تهيئته هنا لاحتواء البطاقات ديناميكياً
            this.pnlMetrics.Location = new System.Drawing.Point(20, 80);
            this.pnlMetrics.Size = new System.Drawing.Size(1160, 150);
            this.pnlMetrics.BackColor = System.Drawing.Color.Transparent;
            this.pnlMetrics.Padding = new Padding(0);
            this.Controls.Add(this.pnlMetrics);

            // تم إزالة جميع منطق FlowLayoutPanel و createCard و Instantiate Cards

            this.ResumeLayout(false);
            this.PerformLayout();
            this.pnlMetrics.ResumeLayout(false);

        }

        #endregion
    }
}