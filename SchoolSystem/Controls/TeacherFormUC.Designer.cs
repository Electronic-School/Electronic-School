namespace SchoolSystem.Controls
{
    partial class TeacherFormUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlSidebar;
        private Panel pnlMainContent;

        private Button btnShowAllTeachers;
        private Button btnSearchTeacher;
        private Button btnAddTeacher;
        private Button btnEditTeacher;
        private Button btnDeleteTeacher;


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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            btnDeleteTeacher = new Button();
            btnEditTeacher = new Button();
            btnAddTeacher = new Button();
            btnSearchTeacher = new Button();
            btnShowAllTeachers = new Button();
            pnlMainContent = new Panel();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSteelBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1482, 71);
            pnlHeader.TabIndex = 2;
            pnlHeader.Text = "Teacher Management System";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(573, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Teacher Management";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.LightGray;
            pnlSidebar.Controls.Add(btnDeleteTeacher);
            pnlSidebar.Controls.Add(btnEditTeacher);
            pnlSidebar.Controls.Add(btnAddTeacher);
            pnlSidebar.Controls.Add(btnSearchTeacher);
            pnlSidebar.Controls.Add(btnShowAllTeachers);
            pnlSidebar.Dock = DockStyle.Right;
            pnlSidebar.Font = new Font("Segoe UI", 14F);
            pnlSidebar.Location = new Point(1220, 71);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(262, 732);
            pnlSidebar.TabIndex = 1;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.Dock = DockStyle.Top;
            btnDeleteTeacher.Location = new Point(0, 280);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(262, 70);
            btnDeleteTeacher.TabIndex = 0;
            btnDeleteTeacher.Text = "Delete Teacher";
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnEditTeacher
            // 
            btnEditTeacher.Dock = DockStyle.Top;
            btnEditTeacher.Location = new Point(0, 210);
            btnEditTeacher.Name = "btnEditTeacher";
            btnEditTeacher.Size = new Size(262, 70);
            btnEditTeacher.TabIndex = 1;
            btnEditTeacher.Text = "Edit Teacher";
            btnEditTeacher.Click += btnEditTeacher_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Dock = DockStyle.Top;
            btnAddTeacher.Location = new Point(0, 140);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(262, 70);
            btnAddTeacher.TabIndex = 2;
            btnAddTeacher.Text = "Add Teacher";
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnSearchTeacher
            // 
            btnSearchTeacher.Dock = DockStyle.Top;
            btnSearchTeacher.Location = new Point(0, 70);
            btnSearchTeacher.Name = "btnSearchTeacher";
            btnSearchTeacher.Size = new Size(262, 70);
            btnSearchTeacher.TabIndex = 3;
            btnSearchTeacher.Text = "Search Teacher By ID";
            btnSearchTeacher.Click += btnSearchTeacher_Click;
            // 
            // btnShowAllTeachers
            // 
            btnShowAllTeachers.Dock = DockStyle.Top;
            btnShowAllTeachers.ForeColor = SystemColors.ControlText;
            btnShowAllTeachers.Location = new Point(0, 0);
            btnShowAllTeachers.Name = "btnShowAllTeachers";
            btnShowAllTeachers.Size = new Size(262, 70);
            btnShowAllTeachers.TabIndex = 4;
            btnShowAllTeachers.Text = "Show All Teachers";
            btnShowAllTeachers.Click += btnShowAllTeachers_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(0, 71);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1220, 732);
            pnlMainContent.TabIndex = 0;
            // 
            // TeacherFormUC
            // 
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "TeacherFormUC";
            Size = new Size(1482, 803);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
