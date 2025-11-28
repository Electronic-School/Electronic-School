namespace SchoolManagementSystem.Forms
{
    partial class TeacherForm
    {
        private Panel sidebar;
        private Panel mainPanel;
        private Panel topPanel;
        private Label lblTitle;
        private Button btnShowTeachers;
        private Button btnAddTeacher;
        private Button btnEditTeacher;
        private Button btnDeleteTeacher;

        private void InitializeComponent()
        {
            sidebar = new Panel();
            btnDeleteTeacher = new Button();
            btnEditTeacher = new Button();
            btnAddTeacher = new Button();
            btnShowTeachers = new Button();
            mainPanel = new Panel();
            topPanel = new Panel();
            lblTitle = new Label();
            sidebar.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(240, 240, 240);
            sidebar.Controls.Add(btnDeleteTeacher);
            sidebar.Controls.Add(btnEditTeacher);
            sidebar.Controls.Add(btnAddTeacher);
            sidebar.Controls.Add(btnShowTeachers);
            sidebar.Dock = DockStyle.Right;
            sidebar.Location = new Point(1282, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 803);
            sidebar.TabIndex = 2;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.BackColor = Color.OrangeRed;
            btnDeleteTeacher.Dock = DockStyle.Top;
            btnDeleteTeacher.FlatAppearance.BorderSize = 0;
            btnDeleteTeacher.FlatStyle = FlatStyle.Flat;
            btnDeleteTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteTeacher.Location = new Point(0, 300);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(200, 100);
            btnDeleteTeacher.TabIndex = 0;
            btnDeleteTeacher.Text = "حذف مدرس";
            btnDeleteTeacher.UseVisualStyleBackColor = false;
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnEditTeacher
            // 
            btnEditTeacher.BackColor = Color.Cyan;
            btnEditTeacher.Dock = DockStyle.Top;
            btnEditTeacher.FlatAppearance.BorderSize = 0;
            btnEditTeacher.FlatStyle = FlatStyle.Flat;
            btnEditTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditTeacher.Location = new Point(0, 200);
            btnEditTeacher.Name = "btnEditTeacher";
            btnEditTeacher.Size = new Size(200, 100);
            btnEditTeacher.TabIndex = 1;
            btnEditTeacher.Text = "تعديل مدرس";
            btnEditTeacher.UseVisualStyleBackColor = false;
            btnEditTeacher.Click += btnEditTeacher_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.FromArgb(144, 238, 144);
            btnAddTeacher.Dock = DockStyle.Top;
            btnAddTeacher.FlatAppearance.BorderSize = 0;
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddTeacher.Location = new Point(0, 100);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(200, 100);
            btnAddTeacher.TabIndex = 2;
            btnAddTeacher.Text = "إضافة مدرس";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnShowTeachers
            // 
            btnShowTeachers.BackColor = Color.FromArgb(180, 200, 255);
            btnShowTeachers.Dock = DockStyle.Top;
            btnShowTeachers.FlatAppearance.BorderSize = 0;
            btnShowTeachers.FlatStyle = FlatStyle.Flat;
            btnShowTeachers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowTeachers.Location = new Point(0, 0);
            btnShowTeachers.Name = "btnShowTeachers";
            btnShowTeachers.Size = new Size(200, 100);
            btnShowTeachers.TabIndex = 3;
            btnShowTeachers.Text = "عرض المدرسين";
            btnShowTeachers.UseVisualStyleBackColor = false;
            btnShowTeachers.Click += btnShowTeachers_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 80);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1282, 723);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(0, 120, 215);
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1282, 80);
            topPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1282, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة المدرسين";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TeacherForm
            // 
            ClientSize = new Size(1482, 803);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Controls.Add(sidebar);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام إدارة المدرسين";
            sidebar.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}