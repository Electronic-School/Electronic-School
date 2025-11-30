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
            txtTeacherId = new TextBox();
            lblTeacherId = new Label();
            btnLoad = new Button();
            pnlTeacherInfo = new Panel();
            lblInfoTitle = new Label();
            lblSocialStatus = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblNumberOfVacations = new Label();
            lblStartWorkingDate = new Label();
            lblTeachingSubject = new Label();
            lblEducationDegree = new Label();
            lblSalary = new Label();
            lblDateOfBirth = new Label();
            lblName = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            lblTitle = new Label();
            pnlTeacherInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(467, 88);
            txtTeacherId.Margin = new Padding(4, 5, 4, 5);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(199, 27);
            txtTeacherId.TabIndex = 1;
            txtTeacherId.TextChanged += txtTeacherId_TextChanged;
            txtTeacherId.KeyPress += txtTeacherId_KeyPress;
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Location = new Point(733, 92);
            lblTeacherId.Margin = new Padding(4, 0, 4, 0);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(87, 20);
            lblTeacherId.TabIndex = 1;
            lblTeacherId.Text = "رقم المدرس:";
            lblTeacherId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(0, 120, 215);
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(293, 85);
            btnLoad.Margin = new Padding(4, 5, 4, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(147, 38);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "تحميل البيانات";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // pnlTeacherInfo
            // 
            pnlTeacherInfo.BackColor = Color.FromArgb(240, 240, 240);
            pnlTeacherInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlTeacherInfo.Controls.Add(lblInfoTitle);
            pnlTeacherInfo.Controls.Add(lblSocialStatus);
            pnlTeacherInfo.Controls.Add(lblEmail);
            pnlTeacherInfo.Controls.Add(lblPhoneNumber);
            pnlTeacherInfo.Controls.Add(lblNumberOfVacations);
            pnlTeacherInfo.Controls.Add(lblStartWorkingDate);
            pnlTeacherInfo.Controls.Add(lblTeachingSubject);
            pnlTeacherInfo.Controls.Add(lblEducationDegree);
            pnlTeacherInfo.Controls.Add(lblSalary);
            pnlTeacherInfo.Controls.Add(lblDateOfBirth);
            pnlTeacherInfo.Controls.Add(lblName);
            pnlTeacherInfo.Location = new Point(67, 154);
            pnlTeacherInfo.Margin = new Padding(4, 5, 4, 5);
            pnlTeacherInfo.Name = "pnlTeacherInfo";
            pnlTeacherInfo.Size = new Size(933, 384);
            pnlTeacherInfo.TabIndex = 3;
            pnlTeacherInfo.DoubleClick += ShowTeacherDetails;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblInfoTitle.Location = new Point(400, 15);
            lblInfoTitle.Margin = new Padding(4, 0, 4, 0);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(108, 20);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "بيانات المدرس:";
            lblInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSocialStatus
            // 
            lblSocialStatus.AutoSize = true;
            lblSocialStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSocialStatus.Location = new Point(200, 138);
            lblSocialStatus.Margin = new Padding(4, 0, 4, 0);
            lblSocialStatus.Name = "lblSocialStatus";
            lblSocialStatus.Size = new Size(115, 18);
            lblSocialStatus.TabIndex = 10;
            lblSocialStatus.Text = "الحالة الاجتماعية: ---";
            lblSocialStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(200, 100);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(113, 18);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "البريد الإلكتروني: ---";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(200, 62);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(84, 18);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "رقم الهاتف: ---";
            lblPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumberOfVacations
            // 
            lblNumberOfVacations.AutoSize = true;
            lblNumberOfVacations.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfVacations.Location = new Point(667, 292);
            lblNumberOfVacations.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfVacations.Name = "lblNumberOfVacations";
            lblNumberOfVacations.Size = new Size(99, 18);
            lblNumberOfVacations.TabIndex = 7;
            lblNumberOfVacations.Text = "عدد الإجازات: ---";
            lblNumberOfVacations.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStartWorkingDate
            // 
            lblStartWorkingDate.AutoSize = true;
            lblStartWorkingDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartWorkingDate.Location = new Point(667, 254);
            lblStartWorkingDate.Margin = new Padding(4, 0, 4, 0);
            lblStartWorkingDate.Name = "lblStartWorkingDate";
            lblStartWorkingDate.Size = new Size(108, 18);
            lblStartWorkingDate.TabIndex = 6;
            lblStartWorkingDate.Text = "تاريخ بدء العمل: ---";
            lblStartWorkingDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTeachingSubject
            // 
            lblTeachingSubject.AutoSize = true;
            lblTeachingSubject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeachingSubject.Location = new Point(667, 215);
            lblTeachingSubject.Margin = new Padding(4, 0, 4, 0);
            lblTeachingSubject.Name = "lblTeachingSubject";
            lblTeachingSubject.Size = new Size(104, 18);
            lblTeachingSubject.TabIndex = 5;
            lblTeachingSubject.Text = "المادة الدراسية: ---";
            lblTeachingSubject.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEducationDegree
            // 
            lblEducationDegree.AutoSize = true;
            lblEducationDegree.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEducationDegree.Location = new Point(667, 177);
            lblEducationDegree.Margin = new Padding(4, 0, 4, 0);
            lblEducationDegree.Name = "lblEducationDegree";
            lblEducationDegree.Size = new Size(100, 18);
            lblEducationDegree.TabIndex = 4;
            lblEducationDegree.Text = "المؤهل العلمي: ---";
            lblEducationDegree.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(667, 138);
            lblSalary.Margin = new Padding(4, 0, 4, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(64, 18);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "الراتب: ---";
            lblSalary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.Location = new Point(667, 100);
            lblDateOfBirth.Margin = new Padding(4, 0, 4, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(93, 18);
            lblDateOfBirth.TabIndex = 2;
            lblDateOfBirth.Text = "تاريخ الميلاد: ---";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(667, 62);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 18);
            lblName.TabIndex = 1;
            lblName.Text = "الاسم: ---";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(560, 569);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 62);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف المدرس";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(373, 569);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 62);
            btnClear.TabIndex = 5;
            btnClear.Text = "مسح الكل";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblTitle.Location = new Point(467, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "حذف مدرس";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_DeleteTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(pnlTeacherInfo);
            Controls.Add(btnLoad);
            Controls.Add(txtTeacherId);
            Controls.Add(lblTeacherId);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_DeleteTeacher";
            Size = new Size(1067, 769);
            Load += UC_DeleteTeacher_Load;
            pnlTeacherInfo.ResumeLayout(false);
            pnlTeacherInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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