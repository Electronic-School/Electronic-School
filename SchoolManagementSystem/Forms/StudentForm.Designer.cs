//using SchoolManagementSystem.Data;
//using SchoolManagementSystem.Models;
namespace SchoolManagementSystem.Forms

{
    public partial class StudentForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    SuspendLayout();
        //    // 
        //    // StudentForm
        //    // 
        //    AutoScaleDimensions = new SizeF(8F, 20F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    ClientSize = new Size(800, 450);
        //    Name = "StudentForm";
        //    Text = "Form1";
        //    Load += this.StudentForm_Load;
        //    ResumeLayout(false);
        //}

        private void StudentForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Panel sidebar;
        private Panel mainPanel;
        private Panel topPanel;
        private Label lblTitle;
        private Button btnShowStudents;
        private Button btnAddStudent;
        private Button btnEditStudent;
        private Button btnDeleteStudent;

        private void InitializeComponent()
        {
            sidebar = new Panel();
            btnDeleteStudent = new Button();
            btnEditStudent = new Button();
            btnAddStudent = new Button();
            btnShowStudents = new Button();
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
            sidebar.Controls.Add(btnDeleteStudent);
            sidebar.Controls.Add(btnEditStudent);
            sidebar.Controls.Add(btnAddStudent);
            sidebar.Controls.Add(btnShowStudents);
            sidebar.Dock = DockStyle.Right;
            sidebar.Location = new Point(1282, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 803);
            sidebar.TabIndex = 2;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = Color.OrangeRed;
            btnDeleteStudent.Dock = DockStyle.Top;
            btnDeleteStudent.FlatAppearance.BorderSize = 0;
            btnDeleteStudent.FlatStyle = FlatStyle.Flat;
            btnDeleteStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteStudent.Location = new Point(0, 300);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(200, 100);
            btnDeleteStudent.TabIndex = 0;
            btnDeleteStudent.Text = "حذف طالب";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.BackColor = Color.Cyan;
            btnEditStudent.Dock = DockStyle.Top;
            btnEditStudent.FlatAppearance.BorderSize = 0;
            btnEditStudent.FlatStyle = FlatStyle.Flat;
            btnEditStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditStudent.Location = new Point(0, 200);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(200, 100);
            btnEditStudent.TabIndex = 1;
            btnEditStudent.Text = "تعديل طالب";
            btnEditStudent.UseVisualStyleBackColor = false;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(144, 238, 144);
            btnAddStudent.Dock = DockStyle.Top;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddStudent.Location = new Point(0, 100);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(200, 100);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "إضافة طالب";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowStudents
            // 
            btnShowStudents.BackColor = Color.FromArgb(180, 200, 255);
            btnShowStudents.Dock = DockStyle.Top;
            btnShowStudents.FlatAppearance.BorderSize = 0;
            btnShowStudents.FlatStyle = FlatStyle.Flat;
            btnShowStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowStudents.Location = new Point(0, 0);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(200, 100);
            btnShowStudents.TabIndex = 3;
            btnShowStudents.Text = "عرض الطلاب";
            btnShowStudents.UseVisualStyleBackColor = false;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 80);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1282, 723);
            mainPanel.TabIndex = 0;
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
            lblTitle.Text = "إدارة الطلاب";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentForm
            // 
            ClientSize = new Size(1482, 803);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Controls.Add(sidebar);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام إدارة الطلاب";
            sidebar.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);

            #endregion
        }
}
