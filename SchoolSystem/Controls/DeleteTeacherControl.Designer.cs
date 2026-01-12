namespace SchoolSystem.Controls
{
    partial class DeleteTeacherControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;

        // عناصر التحكم
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtSubject; // للمادة
        private System.Windows.Forms.TextBox txtDegree;  // للشهادة
        private System.Windows.Forms.TextBox txtEmail;   // للبريد
        private System.Windows.Forms.DateTimePicker dtpDob;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        // التسميات
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWarning;

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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlForm = new Panel();
            lblWarning = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtDegree = new TextBox();
            txtSubject = new TextBox();
            txtEmail = new TextBox();
            dtpDob = new DateTimePicker();
            txtLocation = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtTeacherId = new TextBox();
            lblDegree = new Label();
            lblSubject = new Label();
            lblEmail = new Label();
            lblLocation = new Label();
            lblDOB = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblTeacherId = new Label();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(52, 152, 219);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(629, 93);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delete Teacher";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblWarning);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnSearch);
            pnlForm.Controls.Add(txtDegree);
            pnlForm.Controls.Add(txtSubject);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(dtpDob);
            pnlForm.Controls.Add(txtLocation);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(txtTeacherId);
            pnlForm.Controls.Add(lblDegree);
            pnlForm.Controls.Add(lblSubject);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(lblDOB);
            pnlForm.Controls.Add(lblLastName);
            pnlForm.Controls.Add(lblFirstName);
            pnlForm.Controls.Add(lblTeacherId);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 93);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(34, 27, 34, 27);
            pnlForm.Size = new Size(629, 707);
            pnlForm.TabIndex = 1;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.FromArgb(192, 57, 43);
            lblWarning.Location = new Point(34, 480);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(270, 20);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "Warning: This action cannot be undone!";
            lblWarning.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(423, 520);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 53);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear All";
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(34, 520);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 53);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Teacher";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(309, 29);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDegree
            // 
            txtDegree.Location = new Point(194, 267);
            txtDegree.Margin = new Padding(3, 4, 3, 4);
            txtDegree.Name = "txtDegree";
            txtDegree.ReadOnly = true;
            txtDegree.Size = new Size(399, 27);
            txtDegree.TabIndex = 3;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(194, 213);
            txtSubject.Margin = new Padding(3, 4, 3, 4);
            txtSubject.Name = "txtSubject";
            txtSubject.ReadOnly = true;
            txtSubject.Size = new Size(399, 27);
            txtSubject.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 427);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(399, 27);
            txtEmail.TabIndex = 5;
            // 
            // dtpDob
            // 
            dtpDob.Enabled = false;
            dtpDob.Location = new Point(194, 320);
            dtpDob.Margin = new Padding(3, 4, 3, 4);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(399, 27);
            dtpDob.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(194, 373);
            txtLocation.Margin = new Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(399, 27);
            txtLocation.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(194, 160);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(399, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(194, 107);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(399, 27);
            txtFirstName.TabIndex = 9;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Font = new Font("Segoe UI", 10F);
            txtTeacherId.Location = new Point(194, 33);
            txtTeacherId.Margin = new Padding(3, 4, 3, 4);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(102, 30);
            txtTeacherId.TabIndex = 1;
            txtTeacherId.KeyPress += txtTeacherId_KeyPress;
            // 
            // lblDegree
            // 
            lblDegree.AutoSize = true;
            lblDegree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDegree.Location = new Point(34, 271);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(73, 23);
            lblDegree.TabIndex = 10;
            lblDegree.Text = "Degree:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubject.Location = new Point(34, 217);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(75, 23);
            lblSubject.TabIndex = 11;
            lblSubject.Text = "Subject:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(34, 431);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(34, 377);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(83, 23);
            lblLocation.TabIndex = 13;
            lblLocation.Text = "Location:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDOB.Location = new Point(34, 324);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(120, 23);
            lblDOB.TabIndex = 14;
            lblDOB.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(34, 164);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 23);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(34, 111);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 23);
            lblFirstName.TabIndex = 16;
            lblFirstName.Text = "First Name:";
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTeacherId.Location = new Point(34, 37);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(98, 23);
            lblTeacherId.TabIndex = 17;
            lblTeacherId.Text = "Teacher ID:";
            // 
            // DeleteTeacherControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteTeacherControl";
            Size = new Size(629, 800);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}