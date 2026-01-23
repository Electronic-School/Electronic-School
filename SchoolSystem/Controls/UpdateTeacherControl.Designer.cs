namespace SchoolSystem.Controls
{
    partial class UpdateTeacherControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;

        // عناصر التحكم
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSocialStatus;
        private System.Windows.Forms.TextBox txtLocationId;

        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.DateTimePicker dtpStartWork;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEditLocation;

        // التسميات
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lblLn;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblStartWork;
        private System.Windows.Forms.Label lblLoc;

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
            btnSave = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnEditLocation = new Button();
            txtTeacherId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSubject = new TextBox();
            txtDegree = new TextBox();
            txtSalary = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtSocialStatus = new TextBox();
            txtLocationId = new TextBox();
            dtpDob = new DateTimePicker();
            dtpStartWork = new DateTimePicker();
            lblId = new Label();
            lblFn = new Label();
            lblLn = new Label();
            lblSubject = new Label();
            lblDegree = new Label();
            lblSalary = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblSocial = new Label();
            lblDob = new Label();
            lblStartWork = new Label();
            lblLoc = new Label();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(600, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Teacher";
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnSearch);
            pnlForm.Controls.Add(btnEditLocation);
            pnlForm.Controls.Add(txtTeacherId);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtSubject);
            pnlForm.Controls.Add(txtDegree);
            pnlForm.Controls.Add(txtSalary);
            pnlForm.Controls.Add(txtPhone);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(txtSocialStatus);
            pnlForm.Controls.Add(txtLocationId);
            pnlForm.Controls.Add(dtpDob);
            pnlForm.Controls.Add(dtpStartWork);
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(lblFn);
            pnlForm.Controls.Add(lblLn);
            pnlForm.Controls.Add(lblSubject);
            pnlForm.Controls.Add(lblDegree);
            pnlForm.Controls.Add(lblSalary);
            pnlForm.Controls.Add(lblPhone);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(lblSocial);
            pnlForm.Controls.Add(lblDob);
            pnlForm.Controls.Add(lblStartWork);
            pnlForm.Controls.Add(lblLoc);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(20);
            pnlForm.Size = new Size(600, 580);
            pnlForm.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 530);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(300, 45);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 530);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(260, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEditLocation
            // 
            btnEditLocation.Location = new Point(260, 475);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(80, 30);
            btnEditLocation.TabIndex = 3;
            btnEditLocation.Text = "Edit Loc";
            btnEditLocation.Click += btnEditLocation_Click;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(150, 27);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(100, 27);
            txtTeacherId.TabIndex = 4;
            txtTeacherId.KeyPress += txtTeacherId_KeyPress;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 77);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(350, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 117);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(350, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(150, 157);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(350, 27);
            txtSubject.TabIndex = 7;
            // 
            // txtDegree
            // 
            txtDegree.Location = new Point(150, 197);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new Size(350, 27);
            txtDegree.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(150, 237);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(350, 27);
            txtSalary.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 277);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtSocialStatus
            // 
            txtSocialStatus.Location = new Point(150, 357);
            txtSocialStatus.Name = "txtSocialStatus";
            txtSocialStatus.Size = new Size(350, 27);
            txtSocialStatus.TabIndex = 12;
            // 
            // txtLocationId
            // 
            txtLocationId.Location = new Point(150, 477);
            txtLocationId.Name = "txtLocationId";
            txtLocationId.ReadOnly = true;
            txtLocationId.Size = new Size(100, 27);
            txtLocationId.TabIndex = 13;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(150, 397);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(350, 27);
            dtpDob.TabIndex = 14;
            // 
            // dtpStartWork
            // 
            dtpStartWork.Location = new Point(150, 437);
            dtpStartWork.Name = "dtpStartWork";
            dtpStartWork.Size = new Size(350, 27);
            dtpStartWork.TabIndex = 15;
            // 
            // lblId
            // 
            lblId.Location = new Point(30, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 16;
            lblId.Text = "Teacher ID:";
            lblId.Click += lblId_Click;
            // 
            // lblFn
            // 
            lblFn.Location = new Point(30, 80);
            lblFn.Name = "lblFn";
            lblFn.Size = new Size(100, 23);
            lblFn.TabIndex = 17;
            lblFn.Text = "First Name:";
            // 
            // lblLn
            // 
            lblLn.Location = new Point(30, 120);
            lblLn.Name = "lblLn";
            lblLn.Size = new Size(100, 23);
            lblLn.TabIndex = 18;
            lblLn.Text = "Last Name:";
            // 
            // lblSubject
            // 
            lblSubject.Location = new Point(30, 160);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(100, 23);
            lblSubject.TabIndex = 19;
            lblSubject.Text = "Subject:";
            // 
            // lblDegree
            // 
            lblDegree.Location = new Point(30, 200);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(100, 23);
            lblDegree.TabIndex = 20;
            lblDegree.Text = "Degree:";
            // 
            // lblSalary
            // 
            lblSalary.Location = new Point(30, 240);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(100, 23);
            lblSalary.TabIndex = 21;
            lblSalary.Text = "Salary:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(30, 280);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 22;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(30, 320);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email:";
            // 
            // lblSocial
            // 
            lblSocial.Location = new Point(30, 360);
            lblSocial.Name = "lblSocial";
            lblSocial.Size = new Size(100, 23);
            lblSocial.TabIndex = 24;
            lblSocial.Text = "Social Status:";
            // 
            // lblDob
            // 
            lblDob.Location = new Point(30, 400);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 25;
            lblDob.Text = "Birth Date:";
            // 
            // lblStartWork
            // 
            lblStartWork.Location = new Point(30, 440);
            lblStartWork.Name = "lblStartWork";
            lblStartWork.Size = new Size(100, 23);
            lblStartWork.TabIndex = 26;
            lblStartWork.Text = "Start Date:";
            // 
            // lblLoc
            // 
            lblLoc.Location = new Point(30, 480);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(100, 23);
            lblLoc.TabIndex = 27;
            lblLoc.Text = "Location ID:";
            // 
            // UpdateTeacherControl
            // 
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Name = "UpdateTeacherControl";
            Size = new Size(600, 650);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}