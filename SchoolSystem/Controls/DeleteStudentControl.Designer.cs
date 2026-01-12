namespace SchoolSystem.Controls
{
    partial class DeleteStudentControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlForm;
        private TextBox txtStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtLocation;
        private TextBox txtParent;
        private DateTimePicker dtpDob;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnClear;
        private Label lblStudentId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDOB;
        private Label lblLocation;
        private Label lblParent;
        private Label lblWarning;
        private TextBox txtStudentLevel;
        private Label lblStudentLevel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlForm = new Panel();
            lblWarning = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtStudentLevel = new TextBox();
            dtpDob = new DateTimePicker();
            txtParent = new TextBox();
            txtLocation = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtStudentId = new TextBox();
            lblStudentLevel = new Label();
            lblParent = new Label();
            lblLocation = new Label();
            lblDOB = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblStudentId = new Label();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delete Student";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblWarning);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnSearch);
            pnlForm.Controls.Add(txtStudentLevel);
            pnlForm.Controls.Add(dtpDob);
            pnlForm.Controls.Add(txtParent);
            pnlForm.Controls.Add(txtLocation);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(txtStudentId);
            pnlForm.Controls.Add(lblStudentLevel);
            pnlForm.Controls.Add(lblParent);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(lblDOB);
            pnlForm.Controls.Add(lblLastName);
            pnlForm.Controls.Add(lblFirstName);
            pnlForm.Controls.Add(lblStudentId);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 20, 30, 20);
            pnlForm.Size = new Size(550, 530);
            pnlForm.TabIndex = 1;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWarning.ForeColor = Color.FromArgb(192, 57, 43);
            lblWarning.Location = new Point(33, 370);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(209, 15);
            lblWarning.TabIndex = 17;
            lblWarning.Text = "Warning: This action cannot be undone!";
            lblWarning.Visible = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(149, 165, 166);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(370, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(33, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(44, 62, 80);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(270, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 32);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtStudentLevel
            // 
            txtStudentLevel.BackColor = Color.FromArgb(245, 245, 245);
            txtStudentLevel.Font = new Font("Segoe UI", 10F);
            txtStudentLevel.Location = new Point(170, 195);
            txtStudentLevel.Name = "txtStudentLevel";
            txtStudentLevel.ReadOnly = true;
            txtStudentLevel.Size = new Size(250, 25);
            txtStudentLevel.TabIndex = 13;
            // 
            // dtpDob
            // 
            dtpDob.Enabled = false;
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(170, 235);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(250, 25);
            dtpDob.TabIndex = 12;
            // 
            // txtParent
            // 
            txtParent.BackColor = Color.FromArgb(245, 245, 245);
            txtParent.Font = new Font("Segoe UI", 10F);
            txtParent.Location = new Point(170, 315);
            txtParent.Name = "txtParent";
            txtParent.ReadOnly = true;
            txtParent.Size = new Size(350, 25);
            txtParent.TabIndex = 11;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(245, 245, 245);
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(170, 275);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(350, 25);
            txtLocation.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(245, 245, 245);
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(170, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(350, 25);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(245, 245, 245);
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(170, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(350, 25);
            txtFirstName.TabIndex = 8;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 10F);
            txtStudentId.Location = new Point(170, 25);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(90, 25);
            txtStudentId.TabIndex = 7;
            txtStudentId.KeyPress += txtStudentId_KeyPress;
            // 
            // lblStudentLevel
            // 
            lblStudentLevel.AutoSize = true;
            lblStudentLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentLevel.Location = new Point(33, 200);
            lblStudentLevel.Name = "lblStudentLevel";
            lblStudentLevel.Size = new Size(101, 19);
            lblStudentLevel.TabIndex = 6;
            lblStudentLevel.Text = "Student Level:";
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParent.Location = new Point(33, 320);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(53, 19);
            lblParent.TabIndex = 5;
            lblParent.Text = "Parent:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(33, 280);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(67, 19);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDOB.Location = new Point(33, 240);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(100, 19);
            lblDOB.TabIndex = 3;
            lblDOB.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(33, 150);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 19);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(33, 100);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(81, 19);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentId.Location = new Point(33, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(78, 19);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // DeleteStudentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Name = "DeleteStudentControl";
            Size = new Size(550, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}