namespace SchoolManagementSystem.Controls
{
    partial class UC_DeleteTeacher
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
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlTeacherInfo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEducationDegree = new System.Windows.Forms.Label();
            this.lblTeachingSubject = new System.Windows.Forms.Label();
            this.lblStartWorkingDate = new System.Windows.Forms.Label();
            this.lblNumberOfVacations = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSocialStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.pnlTeacherInfo.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "حذف مدرس";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTeacherId
            this.lblTeacherId.AutoSize = true;
            this.lblTeacherId.Location = new System.Drawing.Point(550, 60);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(60, 13);
            this.lblTeacherId.TabIndex = 1;
            this.lblTeacherId.Text = "رقم المدرس:";
            this.lblTeacherId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // txtTeacherId
            this.txtTeacherId.Location = new System.Drawing.Point(350, 57);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(150, 20);
            this.txtTeacherId.TabIndex = 1;
            this.txtTeacherId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeacherId_KeyPress);
            this.txtTeacherId.TextChanged += new System.EventHandler(this.txtTeacherId_TextChanged);

            // btnLoad
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(220, 55);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 25);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "تحميل البيانات";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // pnlTeacherInfo
            this.pnlTeacherInfo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlTeacherInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTeacherInfo.Controls.Add(this.lblInfoTitle);
            this.pnlTeacherInfo.Controls.Add(this.lblSocialStatus);
            this.pnlTeacherInfo.Controls.Add(this.lblEmail);
            this.pnlTeacherInfo.Controls.Add(this.lblPhoneNumber);
            this.pnlTeacherInfo.Controls.Add(this.lblNumberOfVacations);
            this.pnlTeacherInfo.Controls.Add(this.lblStartWorkingDate);
            this.pnlTeacherInfo.Controls.Add(this.lblTeachingSubject);
            this.pnlTeacherInfo.Controls.Add(this.lblEducationDegree);
            this.pnlTeacherInfo.Controls.Add(this.lblSalary);
            this.pnlTeacherInfo.Controls.Add(this.lblDateOfBirth);
            this.pnlTeacherInfo.Controls.Add(this.lblName);
            this.pnlTeacherInfo.Location = new System.Drawing.Point(50, 100);
            this.pnlTeacherInfo.Name = "pnlTeacherInfo";
            this.pnlTeacherInfo.Size = new System.Drawing.Size(700, 250);
            this.pnlTeacherInfo.TabIndex = 3;
            this.pnlTeacherInfo.DoubleClick += new System.EventHandler(this.ShowTeacherDetails);

            // lblInfoTitle
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblInfoTitle.Location = new System.Drawing.Point(300, 10);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(100, 17);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "بيانات المدرس:";
            this.lblInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(500, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "الاسم: ---";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblDateOfBirth
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(500, 65);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(89, 15);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "تاريخ الميلاد: ---";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblSalary
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(500, 90);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(56, 15);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "الراتب: ---";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblEducationDegree
            this.lblEducationDegree.AutoSize = true;
            this.lblEducationDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationDegree.Location = new System.Drawing.Point(500, 115);
            this.lblEducationDegree.Name = "lblEducationDegree";
            this.lblEducationDegree.Size = new System.Drawing.Size(82, 15);
            this.lblEducationDegree.TabIndex = 4;
            this.lblEducationDegree.Text = "المؤهل العلمي: ---";
            this.lblEducationDegree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblTeachingSubject
            this.lblTeachingSubject.AutoSize = true;
            this.lblTeachingSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachingSubject.Location = new System.Drawing.Point(500, 140);
            this.lblTeachingSubject.Name = "lblTeachingSubject";
            this.lblTeachingSubject.Size = new System.Drawing.Size(87, 15);
            this.lblTeachingSubject.TabIndex = 5;
            this.lblTeachingSubject.Text = "المادة الدراسية: ---";
            this.lblTeachingSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblStartWorkingDate
            this.lblStartWorkingDate.AutoSize = true;
            this.lblStartWorkingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartWorkingDate.Location = new System.Drawing.Point(500, 165);
            this.lblStartWorkingDate.Name = "lblStartWorkingDate";
            this.lblStartWorkingDate.Size = new System.Drawing.Size(84, 15);
            this.lblStartWorkingDate.TabIndex = 6;
            this.lblStartWorkingDate.Text = "تاريخ بدء العمل: ---";
            this.lblStartWorkingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblNumberOfVacations
            this.lblNumberOfVacations.AutoSize = true;
            this.lblNumberOfVacations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfVacations.Location = new System.Drawing.Point(500, 190);
            this.lblNumberOfVacations.Name = "lblNumberOfVacations";
            this.lblNumberOfVacations.Size = new System.Drawing.Size(73, 15);
            this.lblNumberOfVacations.TabIndex = 7;
            this.lblNumberOfVacations.Text = "عدد الإجازات: ---";
            this.lblNumberOfVacations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblPhoneNumber
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(150, 40);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(70, 15);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "رقم الهاتف: ---";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(150, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "البريد الإلكتروني: ---";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblSocialStatus
            this.lblSocialStatus.AutoSize = true;
            this.lblSocialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocialStatus.Location = new System.Drawing.Point(150, 90);
            this.lblSocialStatus.Name = "lblSocialStatus";
            this.lblSocialStatus.Size = new System.Drawing.Size(87, 15);
            this.lblSocialStatus.TabIndex = 10;
            this.lblSocialStatus.Text = "الحالة الاجتماعية: ---";
            this.lblSocialStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(420, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف المدرس";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(280, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "مسح الكل";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // UC_DeleteTeacher
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlTeacherInfo);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.lblTeacherId);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_DeleteTeacher";
            this.Size = new System.Drawing.Size(800, 500);
            this.pnlTeacherInfo.ResumeLayout(false);
            this.pnlTeacherInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlTeacherInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEducationDegree;
        private System.Windows.Forms.Label lblTeachingSubject;
        private System.Windows.Forms.Label lblStartWorkingDate;
        private System.Windows.Forms.Label lblNumberOfVacations;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSocialStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfoTitle;
    }
}