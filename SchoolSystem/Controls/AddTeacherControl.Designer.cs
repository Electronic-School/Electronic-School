namespace SchoolSystem.Controls
{
    partial class AddTeacherControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.TextBox txtTeachingSubject;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpStartWorkingDate;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSocialStatus;

        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEducationDegree;
        private System.Windows.Forms.Label lblTeachingSubject;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblStartWorkingDate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSocialStatus;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolTip toolTip; //  هذا هو التعريف المفقود
        private System.Windows.Forms.Label lblAgeHint;
        private System.Windows.Forms.Label lblRequired;
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
            pnlForm = new Panel();
            cmbEducationDegree = new ComboBox();
            lblAgeHint = new Label();
            lblRequired = new Label();
            lblStatus = new Label();
            btnClear = new Button();
            btnAddTeacher = new Button();
            btnAddLocation = new Button();
            dtpDateOfBirth = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtTeachingSubject = new TextBox();
            txtSalary = new TextBox();
            dtpStartWorkingDate = new DateTimePicker();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtSocialStatus = new TextBox();
            lblLocation = new Label();
            lblDateOfBirth = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblEducationDegree = new Label();
            lblTeachingSubject = new Label();
            lblSalary = new Label();
            lblStartWorkingDate = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblSocialStatus = new Label();
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
            lblTitle.Size = new Size(286, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👨‍🏫 Add New Teacher";
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.Controls.Add(cmbEducationDegree);
            pnlForm.Controls.Add(lblAgeHint);
            pnlForm.Controls.Add(lblRequired);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnAddTeacher);
            pnlForm.Controls.Add(btnAddLocation);
            pnlForm.Controls.Add(dtpDateOfBirth);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(txtTeachingSubject);
            pnlForm.Controls.Add(txtSalary);
            pnlForm.Controls.Add(dtpStartWorkingDate);
            pnlForm.Controls.Add(txtPhoneNumber);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(txtSocialStatus);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(lblDateOfBirth);
            pnlForm.Controls.Add(lblLastName);
            pnlForm.Controls.Add(lblFirstName);
            pnlForm.Controls.Add(lblEducationDegree);
            pnlForm.Controls.Add(lblTeachingSubject);
            pnlForm.Controls.Add(lblSalary);
            pnlForm.Controls.Add(lblStartWorkingDate);
            pnlForm.Controls.Add(lblPhoneNumber);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(lblSocialStatus);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 88);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 25, 30, 25);
            pnlForm.Size = new Size(600, 723);
            pnlForm.TabIndex = 1;
            // 
            // cmbEducationDegree
            // 
            cmbEducationDegree.FlatStyle = FlatStyle.Flat;
            cmbEducationDegree.FormattingEnabled = true;
            cmbEducationDegree.Items.AddRange(new object[] { "Bachelor بكالوريوس", "            ", "Master's ماجستير", " " });
            cmbEducationDegree.Location = new Point(190, 257);
            cmbEducationDegree.Name = "cmbEducationDegree";
            cmbEducationDegree.Size = new Size(370, 28);
            cmbEducationDegree.TabIndex = 25;
            // 
            // lblAgeHint
            // 
            lblAgeHint.AutoSize = true;
            lblAgeHint.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblAgeHint.ForeColor = Color.FromArgb(127, 140, 141);
            lblAgeHint.Location = new Point(490, 156);
            lblAgeHint.Name = "lblAgeHint";
            lblAgeHint.Size = new Size(56, 19);
            lblAgeHint.TabIndex = 17;
            lblAgeHint.Text = "Age: 30";
            lblAgeHint.Visible = false;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.Font = new Font("Segoe UI", 8F);
            lblRequired.ForeColor = Color.FromArgb(231, 76, 60);
            lblRequired.Location = new Point(34, 600);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(181, 19);
            lblRequired.TabIndex = 16;
            lblRequired.Text = "* All fields are required to fill";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(34, 626);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(380, 650);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 44);
            btnClear.TabIndex = 13;
            btnClear.Text = "🗑️ Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddTeacher.Location = new Point(34, 650);
            btnAddTeacher.Margin = new Padding(3, 4, 3, 4);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(340, 44);
            btnAddTeacher.TabIndex = 12;
            btnAddTeacher.Text = "💾 Save Teacher";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += BtnAddTeacher_Click;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Font = new Font("Segoe UI", 9F);
            btnAddLocation.Location = new Point(190, 200);
            btnAddLocation.Margin = new Padding(3, 4, 3, 4);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(370, 40);
            btnAddLocation.TabIndex = 4;
            btnAddLocation.Text = "📍 Add Location Details";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += BtnAddLocation_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 10F);
            dtpDateOfBirth.Location = new Point(190, 150);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(292, 30);
            dtpDateOfBirth.TabIndex = 3;
            dtpDateOfBirth.ValueChanged += DtpDateOfBirth_ValueChanged;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(190, 100);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(370, 30);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(190, 50);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(370, 30);
            txtFirstName.TabIndex = 1;
            // 
            // txtTeachingSubject
            // 
            txtTeachingSubject.Font = new Font("Segoe UI", 10F);
            txtTeachingSubject.Location = new Point(190, 300);
            txtTeachingSubject.Margin = new Padding(3, 4, 3, 4);
            txtTeachingSubject.Name = "txtTeachingSubject";
            txtTeachingSubject.Size = new Size(370, 30);
            txtTeachingSubject.TabIndex = 6;
            txtTeachingSubject.TextChanged += TxtTeachingSubject_TextChanged;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 10F);
            txtSalary.Location = new Point(190, 500);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(370, 30);
            txtSalary.TabIndex = 10;
            // 
            // dtpStartWorkingDate
            // 
            dtpStartWorkingDate.Font = new Font("Segoe UI", 10F);
            dtpStartWorkingDate.Location = new Point(206, 550);
            dtpStartWorkingDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartWorkingDate.Name = "dtpStartWorkingDate";
            dtpStartWorkingDate.Size = new Size(354, 30);
            dtpStartWorkingDate.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.Location = new Point(190, 350);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(370, 30);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(190, 400);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 30);
            txtEmail.TabIndex = 8;
            // 
            // txtSocialStatus
            // 
            txtSocialStatus.Font = new Font("Segoe UI", 10F);
            txtSocialStatus.Location = new Point(190, 450);
            txtSocialStatus.Margin = new Padding(3, 4, 3, 4);
            txtSocialStatus.Name = "txtSocialStatus";
            txtSocialStatus.Size = new Size(370, 30);
            txtSocialStatus.TabIndex = 9;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(34, 206);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(143, 23);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location Details:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(34, 156);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(120, 23);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(34, 106);
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
            // lblEducationDegree
            // 
            lblEducationDegree.AutoSize = true;
            lblEducationDegree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEducationDegree.Location = new Point(34, 256);
            lblEducationDegree.Name = "lblEducationDegree";
            lblEducationDegree.Size = new Size(157, 23);
            lblEducationDegree.TabIndex = 18;
            lblEducationDegree.Text = "Education Degree:";
            // 
            // lblTeachingSubject
            // 
            lblTeachingSubject.AutoSize = true;
            lblTeachingSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTeachingSubject.Location = new Point(34, 306);
            lblTeachingSubject.Name = "lblTeachingSubject";
            lblTeachingSubject.Size = new Size(150, 23);
            lblTeachingSubject.TabIndex = 19;
            lblTeachingSubject.Text = "Teaching Subject:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalary.Location = new Point(34, 506);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(65, 23);
            lblSalary.TabIndex = 23;
            lblSalary.Text = "Salary:";
            // 
            // lblStartWorkingDate
            // 
            lblStartWorkingDate.AutoSize = true;
            lblStartWorkingDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartWorkingDate.Location = new Point(34, 556);
            lblStartWorkingDate.Name = "lblStartWorkingDate";
            lblStartWorkingDate.Size = new Size(173, 23);
            lblStartWorkingDate.TabIndex = 24;
            lblStartWorkingDate.Text = "Start Working Date:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(34, 356);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(136, 23);
            lblPhoneNumber.TabIndex = 20;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(34, 406);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email:";
            // 
            // lblSocialStatus
            // 
            lblSocialStatus.AutoSize = true;
            lblSocialStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSocialStatus.Location = new Point(34, 456);
            lblSocialStatus.Name = "lblSocialStatus";
            lblSocialStatus.Size = new Size(117, 23);
            lblSocialStatus.TabIndex = 22;
            lblSocialStatus.Text = "Social Status:";
            // 
            // AddTeacherControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddTeacherControl";
            Size = new Size(600, 811);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            // 
            // cmbEducationDegree
            // 
            //this.cmbEducationDegree.BackColor = System.Drawing.Color.White; // لون الخلفية أبيض
            //this.cmbEducationDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // منع الكتابة اليدوية
            //this.cmbEducationDegree.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // جعل التصميم مسطحاً ليشبه الـ TextBox
            //this.cmbEducationDegree.Font = new System.Drawing.Font("Segoe UI", 10F); // نفس نوع وحجم الخط للحقول الأخرى
            //this.cmbEducationDegree.FormattingEnabled = true;
            //this.cmbEducationDegree.Location = new System.Drawing.Point(190, 250); // نفس المحاذاة العمودية
            //this.cmbEducationDegree.Name = "cmbEducationDegree";
            //this.cmbEducationDegree.Size = new System.Drawing.Size(370, 31); // نفس العرض (الارتفاع يتحكم به الخط تلقائياً)
            //this.cmbEducationDegree.TabIndex = 5;
        }
        #endregion

        private ComboBox cmbEducationDegree;
    }
}
