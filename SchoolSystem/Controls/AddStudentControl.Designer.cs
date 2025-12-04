namespace SchoolSystem.Controls
{
    partial class AddStudentControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlForm;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtpDateOfBirth;
        private Button btnAddLocation;
        private Button btnAddParent;
        private Button btnAddStudent;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDateOfBirth;
        private Label lblLocation;
        private Label lblParent;
        private Label lblStatus;
        private Button btnClear;
        private ToolTip toolTip;
        private Label lblAgeHint;
        private Label lblRequired;

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
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlForm = new Panel();
            lblAgeHint = new Label();
            lblRequired = new Label();
            lblStatus = new Label();
            btnClear = new Button();
            btnAddStudent = new Button();
            btnAddParent = new Button();
            btnAddLocation = new Button();
            dtpDateOfBirth = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblParent = new Label();
            lblLocation = new Label();
            lblDateOfBirth = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            toolTip = new ToolTip(components);
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
            pnlHeader.Size = new Size(600, 88);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "➕ Add New Student";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblAgeHint);
            pnlForm.Controls.Add(lblRequired);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnAddStudent);
            pnlForm.Controls.Add(btnAddParent);
            pnlForm.Controls.Add(btnAddLocation);
            pnlForm.Controls.Add(dtpDateOfBirth);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(lblParent);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(lblDateOfBirth);
            pnlForm.Controls.Add(lblLastName);
            pnlForm.Controls.Add(lblFirstName);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 88);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 25, 30, 25);
            pnlForm.Size = new Size(600, 662);
            pnlForm.TabIndex = 1;
            // 
            // lblAgeHint
            // 
            lblAgeHint.AutoSize = true;
            lblAgeHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblAgeHint.ForeColor = Color.FromArgb(127, 140, 141);
            lblAgeHint.Location = new Point(280, 181);
            lblAgeHint.Name = "lblAgeHint";
            lblAgeHint.Size = new Size(56, 19);
            lblAgeHint.TabIndex = 17;
            lblAgeHint.Text = "Age: 10";
            lblAgeHint.Visible = false;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.Font = new Font("Segoe UI", 8F);
            lblRequired.ForeColor = Color.FromArgb(231, 76, 60);
            lblRequired.Location = new Point(33, 426);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(181, 19);
            lblRequired.TabIndex = 16;
            lblRequired.Text = "* All fields are required to fill";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(34, 406);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(180, 369);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 44);
            btnClear.TabIndex = 14;
            btnClear.Text = "🗑️ Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddStudent.Location = new Point(33, 480);
            btnAddStudent.Margin = new Padding(3, 4, 3, 4);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(516, 56);
            btnAddStudent.TabIndex = 13;
            btnAddStudent.Text = "💾 Save Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddParent
            // 
            btnAddParent.Font = new Font("Segoe UI", 9F);
            btnAddParent.Location = new Point(180, 306);
            btnAddParent.Margin = new Padding(3, 4, 3, 4);
            btnAddParent.Name = "btnAddParent";
            btnAddParent.Size = new Size(370, 44);
            btnAddParent.TabIndex = 12;
            btnAddParent.Text = "👤 Add Parent Details";
            btnAddParent.UseVisualStyleBackColor = true;
            btnAddParent.Click += btnAddParent_Click;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Font = new Font("Segoe UI", 9F);
            btnAddLocation.Location = new Point(180, 250);
            btnAddLocation.Margin = new Padding(3, 4, 3, 4);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(370, 44);
            btnAddLocation.TabIndex = 11;
            btnAddLocation.Text = "📍 Add Location Details";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 10F);
            dtpDateOfBirth.Location = new Point(180, 175);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(302, 30);
            dtpDateOfBirth.TabIndex = 10;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(180, 112);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(370, 30);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(180, 50);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(370, 30);
            txtFirstName.TabIndex = 8;
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParent.Location = new Point(34, 312);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(127, 23);
            lblParent.TabIndex = 7;
            lblParent.Text = "Parent Details:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(34, 256);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(143, 23);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location Details:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(34, 181);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(120, 23);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(34, 119);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 23);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(34, 56);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 23);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // AddStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddStudentControl";
            Size = new Size(600, 750);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}