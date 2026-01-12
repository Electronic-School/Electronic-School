namespace SchoolSystem
{
    partial class MDIMainFormAdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMainFormAdministrationForm));
            panelTopNav = new Panel();
            lblSchoolName = new Label();
            panelSidebar = new Panel();
            panel1 = new Panel();
            btnSidebarTeacherManage = new Button();
            btnSidebarStudentManage = new Button();
            btnSidebarDashboard = new Button();
            panelContent = new Panel();
            panelTopNav.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopNav
            // 
            panelTopNav.BackColor = Color.SkyBlue;
            panelTopNav.Controls.Add(lblSchoolName);
            panelTopNav.Dock = DockStyle.Top;
            panelTopNav.Location = new Point(0, 0);
            panelTopNav.Name = "panelTopNav";
            panelTopNav.Size = new Size(1482, 79);
            panelTopNav.TabIndex = 2;
            // 
            // lblSchoolName
            // 
            lblSchoolName.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSchoolName.Image = (Image)resources.GetObject("lblSchoolName.Image");
            lblSchoolName.ImageAlign = ContentAlignment.MiddleLeft;
            lblSchoolName.Location = new Point(13, 15);
            lblSchoolName.Name = "lblSchoolName";
            lblSchoolName.Size = new Size(365, 40);
            lblSchoolName.TabIndex = 0;
            lblSchoolName.Text = " Electronic School";
            lblSchoolName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.PowderBlue;
            panelSidebar.Controls.Add(panel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 79);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(316, 724);
            panelSidebar.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btnSidebarTeacherManage);
            panel1.Controls.Add(btnSidebarStudentManage);
            panel1.Controls.Add(btnSidebarDashboard);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 724);
            panel1.TabIndex = 4;
            // 
            // btnSidebarTeacherManage
            // 
            btnSidebarTeacherManage.Dock = DockStyle.Top;
            btnSidebarTeacherManage.FlatAppearance.BorderSize = 0;
            btnSidebarTeacherManage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarTeacherManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebarTeacherManage.Location = new Point(0, 180);
            btnSidebarTeacherManage.Name = "btnSidebarTeacherManage";
            btnSidebarTeacherManage.RightToLeft = RightToLeft.No;
            btnSidebarTeacherManage.Size = new Size(316, 85);
            btnSidebarTeacherManage.TabIndex = 6;
            btnSidebarTeacherManage.Text = "Teacher Mangement";
            btnSidebarTeacherManage.UseVisualStyleBackColor = true;
            btnSidebarTeacherManage.Click += btnSidebarTeacherManage_Click;
            // 
            // btnSidebarStudentManage
            // 
            btnSidebarStudentManage.Dock = DockStyle.Top;
            btnSidebarStudentManage.FlatAppearance.BorderSize = 0;
            btnSidebarStudentManage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarStudentManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebarStudentManage.Location = new Point(0, 95);
            btnSidebarStudentManage.Name = "btnSidebarStudentManage";
            btnSidebarStudentManage.RightToLeft = RightToLeft.No;
            btnSidebarStudentManage.Size = new Size(316, 85);
            btnSidebarStudentManage.TabIndex = 5;
            btnSidebarStudentManage.Text = "Student Mangement";
            btnSidebarStudentManage.UseVisualStyleBackColor = true;
            btnSidebarStudentManage.Click += btnSidebarStudentManage_Click;
            // 
            // btnSidebarDashboard
            // 
            btnSidebarDashboard.Dock = DockStyle.Top;
            btnSidebarDashboard.FlatAppearance.BorderSize = 0;
            btnSidebarDashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebarDashboard.Location = new Point(0, 0);
            btnSidebarDashboard.Name = "btnSidebarDashboard";
            btnSidebarDashboard.RightToLeft = RightToLeft.No;
            btnSidebarDashboard.Size = new Size(316, 95);
            btnSidebarDashboard.TabIndex = 0;
            btnSidebarDashboard.Text = "Dashboard";
            btnSidebarDashboard.UseVisualStyleBackColor = true;
            btnSidebarDashboard.Click += btnSidebarDashboard_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(316, 79);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1166, 724);
            panelContent.TabIndex = 4;
            // 
            // MDIMainFormAdministrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 803);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelTopNav);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MDIMainFormAdministrationForm";
            Text = "Electronic School Management System";
            panelTopNav.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel panelTopNav;
        private Panel panelSidebar;
        private Panel panelContent;
        private Label lblSchoolName;
        private Panel panel1;
        private Button btnSidebarDashboard;
        private Button btnSidebarStudentManage;
        private Button btnSidebarTeacherManage;
    }
}



