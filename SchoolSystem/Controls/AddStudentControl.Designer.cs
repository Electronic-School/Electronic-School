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
        private ComboBox cmbLevel;
        private Label lblLevel;
        private Label lblLocationStatus;
        private Label lblParentStatus;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblLevelError;
        private Label lblDateOfBirthError;
        private Label lblLocationError;
        private Label lblParentError;

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
            lblLevelError = new Label();
            lblParentError = new Label();
            lblLocationError = new Label();
            lblDateOfBirthError = new Label();
            lblLastNameError = new Label();
            lblFirstNameError = new Label();
            lblParentStatus = new Label();
            lblLocationStatus = new Label();
            cmbLevel = new ComboBox();
            lblLevel = new Label();
            lblAgeHint = new Label();
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
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "➕ Add New Student";
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblLevelError);
            pnlForm.Controls.Add(lblParentError);
            pnlForm.Controls.Add(lblLocationError);
            pnlForm.Controls.Add(lblDateOfBirthError);
            pnlForm.Controls.Add(lblLastNameError);
            pnlForm.Controls.Add(lblFirstNameError);
            pnlForm.Controls.Add(lblParentStatus);
            pnlForm.Controls.Add(lblLocationStatus);
            pnlForm.Controls.Add(cmbLevel);
            pnlForm.Controls.Add(lblLevel);
            pnlForm.Controls.Add(lblAgeHint);
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
            pnlForm.Location = new Point(0, 60);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(20, 15, 20, 15);
            pnlForm.Size = new Size(700, 540);
            pnlForm.TabIndex = 1;
            // 
            // lblLevelError
            // 
            lblLevelError.AutoSize = true;
            lblLevelError.Font = new Font("Segoe UI", 8F);
            lblLevelError.ForeColor = Color.FromArgb(231, 76, 60);
            lblLevelError.Location = new Point(180, 204);
            lblLevelError.Name = "lblLevelError";
            lblLevelError.Size = new Size(0, 19);
            lblLevelError.TabIndex = 21;
            lblLevelError.Visible = false;
            // 
            // lblParentError
            // 
            lblParentError.AutoSize = true;
            lblParentError.Font = new Font("Segoe UI", 8F);
            lblParentError.ForeColor = Color.FromArgb(231, 76, 60);
            lblParentError.Location = new Point(180, 380);
            lblParentError.Name = "lblParentError";
            lblParentError.Size = new Size(0, 19);
            lblParentError.TabIndex = 20;
            lblParentError.Visible = false;
            // 
            // lblLocationError
            // 
            lblLocationError.AutoSize = true;
            lblLocationError.Font = new Font("Segoe UI", 8F);
            lblLocationError.ForeColor = Color.FromArgb(231, 76, 60);
            lblLocationError.Location = new Point(180, 305);
            lblLocationError.Name = "lblLocationError";
            lblLocationError.Size = new Size(0, 19);
            lblLocationError.TabIndex = 19;
            lblLocationError.Visible = false;
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.AutoSize = true;
            lblDateOfBirthError.Font = new Font("Segoe UI", 8F);
            lblDateOfBirthError.ForeColor = Color.FromArgb(231, 76, 60);
            lblDateOfBirthError.Location = new Point(180, 170);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(0, 19);
            lblDateOfBirthError.TabIndex = 18;
            lblDateOfBirthError.Visible = false;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 8F);
            lblLastNameError.ForeColor = Color.FromArgb(231, 76, 60);
            lblLastNameError.Location = new Point(180, 64);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(0, 19);
            lblLastNameError.TabIndex = 17;
            lblLastNameError.Visible = false;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 8F);
            lblFirstNameError.ForeColor = Color.FromArgb(231, 76, 60);
            lblFirstNameError.Location = new Point(180, 127);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(0, 19);
            lblFirstNameError.TabIndex = 16;
            lblFirstNameError.Visible = false;
            // 
            // lblParentStatus
            // 
            lblParentStatus.AutoSize = true;
            lblParentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblParentStatus.ForeColor = Color.FromArgb(39, 174, 96);
            lblParentStatus.Location = new Point(370, 390);
            lblParentStatus.Name = "lblParentStatus";
            lblParentStatus.Size = new Size(0, 20);
            lblParentStatus.TabIndex = 15;
            lblParentStatus.Visible = false;
            // 
            // lblLocationStatus
            // 
            lblLocationStatus.AutoSize = true;
            lblLocationStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocationStatus.ForeColor = Color.FromArgb(39, 174, 96);
            lblLocationStatus.Location = new Point(200, 343);
            lblLocationStatus.Name = "lblLocationStatus";
            lblLocationStatus.Size = new Size(0, 20);
            lblLocationStatus.TabIndex = 14;
            lblLocationStatus.Visible = false;
            // 
            // cmbLevel
            // 
            cmbLevel.Font = new Font("Segoe UI", 10F);
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(180, 270);
            cmbLevel.Margin = new Padding(3, 4, 3, 4);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(470, 31);
            cmbLevel.TabIndex = 3;
            cmbLevel.SelectedIndexChanged += cmbLevel_SelectedIndexChanged;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI Semibold", 10F);
            lblLevel.ForeColor = Color.FromArgb(44, 62, 80);
            lblLevel.Location = new Point(30, 270);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(132, 23);
            lblLevel.TabIndex = 12;
            lblLevel.Text = "Academic Level:";
            // 
            // lblAgeHint
            // 
            lblAgeHint.AutoSize = true;
            lblAgeHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblAgeHint.ForeColor = Color.Gray;
            lblAgeHint.Location = new Point(490, 170);
            lblAgeHint.Name = "lblAgeHint";
            lblAgeHint.Size = new Size(56, 19);
            lblAgeHint.TabIndex = 11;
            lblAgeHint.Text = "Age: 10";
            lblAgeHint.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(39, 174, 96);
            lblStatus.Location = new Point(30, 430);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 10;
            lblStatus.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10F);
            btnClear.Location = new Point(200, 470);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 44);
            btnClear.TabIndex = 9;
            btnClear.Text = "🗑️ Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAddStudent.Location = new Point(30, 470);
            btnAddStudent.Margin = new Padding(3, 4, 3, 4);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(150, 44);
            btnAddStudent.TabIndex = 8;
            btnAddStudent.Text = "💾 Save Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddParent
            // 
            btnAddParent.Font = new Font("Segoe UI Semibold", 10F);
            btnAddParent.Location = new Point(180, 380);
            btnAddParent.Margin = new Padding(3, 4, 3, 4);
            btnAddParent.Name = "btnAddParent";
            btnAddParent.Size = new Size(470, 44);
            btnAddParent.TabIndex = 7;
            btnAddParent.Text = "👤 Add Parent Details";
            btnAddParent.UseVisualStyleBackColor = true;
            btnAddParent.Click += btnAddParent_Click;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Font = new Font("Segoe UI Semibold", 10F);
            btnAddLocation.Location = new Point(180, 330);
            btnAddLocation.Margin = new Padding(3, 4, 3, 4);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(470, 44);
            btnAddLocation.TabIndex = 6;
            btnAddLocation.Text = "📍 Add Location Details";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 10F);
            dtpDateOfBirth.Location = new Point(180, 170);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(300, 30);
            dtpDateOfBirth.TabIndex = 5;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(180, 93);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 30);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(180, 30);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 30);
            txtFirstName.TabIndex = 1;
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI Semibold", 10F);
            lblParent.ForeColor = Color.FromArgb(44, 62, 80);
            lblParent.Location = new Point(30, 380);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(64, 23);
            lblParent.TabIndex = 4;
            lblParent.Text = "Parent:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI Semibold", 10F);
            lblLocation.ForeColor = Color.FromArgb(44, 62, 80);
            lblLocation.Location = new Point(30, 330);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(79, 23);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Location:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI Semibold", 10F);
            lblDateOfBirth.ForeColor = Color.FromArgb(44, 62, 80);
            lblDateOfBirth.Location = new Point(30, 170);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(112, 23);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 10F);
            lblLastName.ForeColor = Color.FromArgb(44, 62, 80);
            lblLastName.Location = new Point(30, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 10F);
            lblFirstName.ForeColor = Color.FromArgb(44, 62, 80);
            lblFirstName.Location = new Point(30, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 23);
            lblFirstName.TabIndex = 0;
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
            Size = new Size(700, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}