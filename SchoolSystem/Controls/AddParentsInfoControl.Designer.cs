namespace SchoolSystem.Controls
{
    partial class ParentAddControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlForm;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtChildrenCount;
        private DateTimePicker dtpDateOfBirth;
        private Button btnSelectLocation;
        private Button btnAddParent;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblChildrenCount;
        private Label lblDateOfBirth;
        private Label lblLocation;
        private ToolTip toolTip;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblPhoneError;
        private Label lblEmailError;
        private Label lblChildrenCountError;
        private Label lblStatus;
        private Button btnClear;

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
            lblStatus = new Label();
            lblChildrenCountError = new Label();
            lblEmailError = new Label();
            lblPhoneError = new Label();
            lblLastNameError = new Label();
            lblFirstNameError = new Label();
            btnClear = new Button();
            btnAddParent = new Button();
            btnSelectLocation = new Button();
            dtpDateOfBirth = new DateTimePicker();
            txtChildrenCount = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLocation = new Label();
            lblDateOfBirth = new Label();
            lblChildrenCount = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
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
            pnlHeader.Size = new Size(500, 61);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👤 Add Parent";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(lblChildrenCountError);
            pnlForm.Controls.Add(lblEmailError);
            pnlForm.Controls.Add(lblPhoneError);
            pnlForm.Controls.Add(lblLastNameError);
            pnlForm.Controls.Add(lblFirstNameError);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnAddParent);
            pnlForm.Controls.Add(btnSelectLocation);
            pnlForm.Controls.Add(dtpDateOfBirth);
            pnlForm.Controls.Add(txtChildrenCount);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(txtPhone);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(lblDateOfBirth);
            pnlForm.Controls.Add(lblChildrenCount);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(lblPhone);
            pnlForm.Controls.Add(lblLastName);
            pnlForm.Controls.Add(lblFirstName);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 61);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 19, 30, 25);
            pnlForm.Size = new Size(500, 1000);
            pnlForm.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(34, 512);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 22;
            lblStatus.Visible = false;
            // 
            // lblChildrenCountError
            // 
            lblChildrenCountError.AutoSize = true;
            lblChildrenCountError.Font = new Font("Segoe UI", 8F);
            lblChildrenCountError.ForeColor = Color.FromArgb(231, 76, 60);
            lblChildrenCountError.Location = new Point(180, 325);
            lblChildrenCountError.Name = "lblChildrenCountError";
            lblChildrenCountError.Size = new Size(0, 19);
            lblChildrenCountError.TabIndex = 21;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 8F);
            lblEmailError.ForeColor = Color.FromArgb(231, 76, 60);
            lblEmailError.Location = new Point(180, 250);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 19);
            lblEmailError.TabIndex = 20;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.Font = new Font("Segoe UI", 8F);
            lblPhoneError.ForeColor = Color.FromArgb(231, 76, 60);
            lblPhoneError.Location = new Point(180, 175);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(0, 19);
            lblPhoneError.TabIndex = 19;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 8F);
            lblLastNameError.ForeColor = Color.FromArgb(231, 76, 60);
            lblLastNameError.Location = new Point(180, 100);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(0, 19);
            lblLastNameError.TabIndex = 18;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 8F);
            lblFirstNameError.ForeColor = Color.FromArgb(231, 76, 60);
            lblFirstNameError.Location = new Point(180, 25);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(0, 19);
            lblFirstNameError.TabIndex = 17;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(180, 355);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 44);
            btnClear.TabIndex = 16;
            btnClear.Text = "🗑️ Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddParent
            // 
            btnAddParent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddParent.Location = new Point(30, 355);
            btnAddParent.Margin = new Padding(3, 4, 3, 4);
            btnAddParent.Name = "btnAddParent";
            btnAddParent.Size = new Size(140, 44);
            btnAddParent.TabIndex = 15;
            btnAddParent.Text = "➕ Add Parent";
            btnAddParent.UseVisualStyleBackColor = true;
            btnAddParent.Click += btnAddParent_Click;
            // 
            // btnSelectLocation
            // 
            btnSelectLocation.Font = new Font("Segoe UI", 9F);
            btnSelectLocation.Location = new Point(160, 303);
            btnSelectLocation.Margin = new Padding(3, 4, 3, 4);
            btnSelectLocation.Name = "btnSelectLocation";
            btnSelectLocation.Size = new Size(270, 44);
            btnSelectLocation.TabIndex = 14;
            btnSelectLocation.Text = "📍 Select Location";
            btnSelectLocation.UseVisualStyleBackColor = true;
            btnSelectLocation.Click += btnSelectLocation_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 10F);
            dtpDateOfBirth.Location = new Point(170, 250);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(280, 30);
            dtpDateOfBirth.TabIndex = 13;
            // 
            // txtChildrenCount
            // 
            txtChildrenCount.Font = new Font("Segoe UI", 10F);
            txtChildrenCount.Location = new Point(180, 206);
            txtChildrenCount.Margin = new Padding(3, 4, 3, 4);
            txtChildrenCount.Name = "txtChildrenCount";
            txtChildrenCount.Size = new Size(120, 30);
            txtChildrenCount.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(180, 158);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 30);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(180, 109);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(270, 30);
            txtPhone.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(180, 63);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(270, 30);
            txtLastName.TabIndex = 9;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(180, 19);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(270, 30);
            txtFirstName.TabIndex = 8;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(34, 303);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(83, 23);
            lblLocation.TabIndex = 7;
            lblLocation.Text = "Location:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(34, 250);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(120, 23);
            lblDateOfBirth.TabIndex = 6;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblChildrenCount
            // 
            lblChildrenCount.AutoSize = true;
            lblChildrenCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChildrenCount.Location = new Point(34, 206);
            lblChildrenCount.Name = "lblChildrenCount";
            lblChildrenCount.Size = new Size(136, 23);
            lblChildrenCount.TabIndex = 5;
            lblChildrenCount.Text = "Children Count:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(34, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.Location = new Point(34, 109);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(64, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(34, 63);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 23);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(34, 19);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            lblFirstName.Click += lblFirstName_Click;
            // 
            // ParentAddControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ParentAddControl";
            Size = new Size(500, 1000);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}