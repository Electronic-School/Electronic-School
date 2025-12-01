using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controls
{
    public partial class LocationsControl : UserControl
    {
        public LocationsControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 600);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "إدارة المواقع (Locations Management)";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationsControl
            // 
            this.Controls.Add(this.labelTitle);
            this.Name = "LocationsControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTitle;

    }
}
