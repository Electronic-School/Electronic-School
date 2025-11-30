namespace SchoolManagementSystem.Controls
{
    partial class UC_AddTeacher
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEducationDegree = new System.Windows.Forms.TextBox();
            this.txtTeachingSubject = new System.Windows.Forms.TextBox();
            this.dtpStartWorkingDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfVacations = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbSocialStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEducationDegree = new System.Windows.Forms.Label();
            this.lblTeachingSubject = new System.Windows.Forms.Label();
            this.lblStartWorkingDate = new System.Windows.Forms.Label();
            this.lblNumberOfVacations = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSocialStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة مدرس جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(550, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "الاسم الأول:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(350, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 1;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(550, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "الاسم الأخير:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(350, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 2;

            // lblDateOfBirth
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(550, 130);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "تاريخ الميلاد:";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // dtpDateOfBirth
            this.dtpDateOfBirth.Location = new System.Drawing.Point(350, 127);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(180, 20);
            this.dtpDateOfBirth.TabIndex = 3;
            this.dtpDateOfBirth.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);

            // lblSalary
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(550, 160);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "الراتب:";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtSalary
            this.txtSalary.Location = new System.Drawing.Point(350, 157);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(180, 20);
            this.txtSalary.TabIndex = 4;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);

            // lblEducationDegree
            this.lblEducationDegree.AutoSize = true;
            this.lblEducationDegree.Location = new System.Drawing.Point(550, 190);
            this.lblEducationDegree.Name = "lblEducationDegree";
            this.lblEducationDegree.Size = new System.Drawing.Size(72, 13);
            this.lblEducationDegree.TabIndex = 9;
            this.lblEducationDegree.Text = "المؤهل العلمي:";
            this.lblEducationDegree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtEducationDegree
            this.txtEducationDegree.Location = new System.Drawing.Point(350, 187);
            this.txtEducationDegree.Name = "txtEducationDegree";
            this.txtEducationDegree.Size = new System.Drawing.Size(180, 20);
            this.txtEducationDegree.TabIndex = 5;

            // lblTeachingSubject
            this.lblTeachingSubject.AutoSize = true;
            this.lblTeachingSubject.Location = new System.Drawing.Point(550, 220);
            this.lblTeachingSubject.Name = "lblTeachingSubject";
            this.lblTeachingSubject.Size = new System.Drawing.Size(77, 13);
            this.lblTeachingSubject.TabIndex = 11;
            this.lblTeachingSubject.Text = "المادة الدراسية:";
            this.lblTeachingSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtTeachingSubject
            this.txtTeachingSubject.Location = new System.Drawing.Point(350, 217);
            this.txtTeachingSubject.Name = "txtTeachingSubject";
            this.txtTeachingSubject.Size = new System.Drawing.Size(180, 20);
            this.txtTeachingSubject.TabIndex = 6;

            // lblStartWorkingDate
            this.lblStartWorkingDate.AutoSize = true;
            this.lblStartWorkingDate.Location = new System.Drawing.Point(550, 250);
            this.lblStartWorkingDate.Name = "lblStartWorkingDate";
            this.lblStartWorkingDate.Size = new System.Drawing.Size(74, 13);
            this.lblStartWorkingDate.TabIndex = 13;
            this.lblStartWorkingDate.Text = "تاريخ بدء العمل:";
            this.lblStartWorkingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // dtpStartWorkingDate
            this.dtpStartWorkingDate.Location = new System.Drawing.Point(350, 247);
            this.dtpStartWorkingDate.Name = "dtpStartWorkingDate";
            this.dtpStartWorkingDate.Size = new System.Drawing.Size(180, 20);
            this.dtpStartWorkingDate.TabIndex = 7;

            // lblNumberOfVacations
            this.lblNumberOfVacations.AutoSize = true;
            this.lblNumberOfVacations.Location = new System.Drawing.Point(550, 280);
            this.lblNumberOfVacations.Name = "lblNumberOfVacations";
            this.lblNumberOfVacations.Size = new System.Drawing.Size(63, 13);
            this.lblNumberOfVacations.TabIndex = 15;
            this.lblNumberOfVacations.Text = "عدد الإجازات:";
            this.lblNumberOfVacations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtNumberOfVacations
            this.txtNumberOfVacations.Location = new System.Drawing.Point(350, 277);
            this.txtNumberOfVacations.Name = "txtNumberOfVacations";
            this.txtNumberOfVacations.Size = new System.Drawing.Size(180, 20);
            this.txtNumberOfVacations.TabIndex = 8;
            this.txtNumberOfVacations.Text = "0";
            this.txtNumberOfVacations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfVacations_KeyPress);

            // lblPhoneNumber
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(550, 310);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(60, 13);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "رقم الهاتف:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtPhoneNumber
            this.txtPhoneNumber.Location = new System.Drawing.Point(350, 307);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(550, 340);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "البريد الإلكتروني:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(350, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 10;

            // lblSocialStatus
            this.lblSocialStatus.AutoSize = true;
            this.lblSocialStatus.Location = new System.Drawing.Point(550, 370);
            this.lblSocialStatus.Name = "lblSocialStatus";
            this.lblSocialStatus.Size = new System.Drawing.Size(77, 13);
            this.lblSocialStatus.TabIndex = 21;
            this.lblSocialStatus.Text = "الحالة الاجتماعية:";
            this.lblSocialStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // cmbSocialStatus
            this.cmbSocialStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocialStatus.FormattingEnabled = true;
            this.cmbSocialStatus.Items.AddRange(new object[] {
            "أعزب",
            "متزوج",
            "مطلق",
            "أرمل"});
            this.cmbSocialStatus.Location = new System.Drawing.Point(350, 367);
            this.cmbSocialStatus.Name = "cmbSocialStatus";
            this.cmbSocialStatus.Size = new System.Drawing.Size(180, 21);
            this.cmbSocialStatus.TabIndex = 11;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(420, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ المدرس";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(290, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "مسح الحقول";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // UC_AddTeacher
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSocialStatus);
            this.Controls.Add(this.lblSocialStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtNumberOfVacations);
            this.Controls.Add(this.lblNumberOfVacations);
            this.Controls.Add(this.dtpStartWorkingDate);
            this.Controls.Add(this.lblStartWorkingDate);
            this.Controls.Add(this.txtTeachingSubject);
            this.Controls.Add(this.lblTeachingSubject);
            this.Controls.Add(this.txtEducationDegree);
            this.Controls.Add(this.lblEducationDegree);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_AddTeacher";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEducationDegree;
        private System.Windows.Forms.TextBox txtTeachingSubject;
        private System.Windows.Forms.DateTimePicker dtpStartWorkingDate;
        private System.Windows.Forms.TextBox txtNumberOfVacations;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbSocialStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEducationDegree;
        private System.Windows.Forms.Label lblTeachingSubject;
        private System.Windows.Forms.Label lblStartWorkingDate;
        private System.Windows.Forms.Label lblNumberOfVacations;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSocialStatus;
        private System.Windows.Forms.Label lblTitle;
    }
}