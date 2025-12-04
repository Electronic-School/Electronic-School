namespace SchoolSystem.Controls
{
    partial class TeacherManagementUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelToolbar = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panelContent = new Panel();
            dgvTeachers = new DataGridView();
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(704, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(409, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Teacher Records Management";
            // 
            // panelToolbar
            // 
            panelToolbar.Controls.Add(btnDelete);
            panelToolbar.Controls.Add(btnEdit);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 50);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(704, 60);
            panelToolbar.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(503, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(276, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Selected";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(53, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New Teacher";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dgvTeachers);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 110);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(704, 377);
            panelContent.TabIndex = 2;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.Location = new Point(0, 0);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.Size = new Size(704, 377);
            dgvTeachers.TabIndex = 0;
            // 
            // TeacherManagementUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            Name = "TeacherManagementUC";
            Size = new Size(704, 487);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panelContent;
        private DataGridView dgvTeachers;
    }
}
