namespace SchoolSystem.Controls
{
    partial class SearchStudentControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Panel pnlResults;
        private Label lblTitle;
        private TextBox txtStudentID;
        private Button btnSearch;
        private Button btnClear;
        private Label lblStudentID;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtDOB;
        private Label lblDOB;
        private TextBox txtLocation;
        private Label lblLocation;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtCountry;
        private Label lblCountry;
        private TextBox txtParentName;
        private Label lblParentName;
        private TextBox txtParentPhone;
        private Label lblParentPhone;
        private TextBox txtParentEmail;
        private Label lblParentEmail;
        private Button btnExport;
        private Label lblLevel;
        private TextBox txtLevel;
        private Label lblStage;
        private TextBox txtStage;
        private Panel pnlPersonalInfo;
        private Panel pnlAcademicInfo;
        private Panel pnlLocationInfo;
        private Panel pnlParentInfo;

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnExport = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            lblTitle = new Label();
            pnlResults = new Panel();
            pnlParentInfo = new Panel();
            txtParentEmail = new TextBox();
            lblParentEmail = new Label();
            txtParentPhone = new TextBox();
            lblParentPhone = new Label();
            txtParentName = new TextBox();
            lblParentName = new Label();
            pnlLocationInfo = new Panel();
            txtCountry = new TextBox();
            lblCountry = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtLocation = new TextBox();
            lblLocation = new Label();
            pnlAcademicInfo = new Panel();
            txtStage = new TextBox();
            lblStage = new Label();
            txtLevel = new TextBox();
            lblLevel = new Label();
            pnlPersonalInfo = new Panel();
            txtDOB = new TextBox();
            lblDOB = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            pnlHeader.SuspendLayout();
            pnlResults.SuspendLayout();
            pnlParentInfo.SuspendLayout();
            pnlLocationInfo.SuspendLayout();
            pnlAcademicInfo.SuspendLayout();
            pnlPersonalInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(btnExport);
            pnlHeader.Controls.Add(btnClear);
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(txtStudentID);
            pnlHeader.Controls.Add(lblStudentID);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 130);
            pnlHeader.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(39, 174, 96);
            btnExport.Enabled = false;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(650, 70);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 30);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(149, 165, 166);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(520, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Enabled = false;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(380, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 10F);
            txtStudentID.Location = new Point(200, 70);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 30);
            txtStudentID.TabIndex = 2;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            txtStudentID.KeyPress += txtStudentID_KeyPress;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentID.ForeColor = Color.White;
            lblStudentID.Location = new Point(100, 75);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(102, 23);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID:";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search Student";
            // 
            // pnlResults
            // 
            pnlResults.AutoScroll = true;
            pnlResults.BackColor = Color.White;
            pnlResults.Controls.Add(pnlParentInfo);
            pnlResults.Controls.Add(pnlLocationInfo);
            pnlResults.Controls.Add(pnlAcademicInfo);
            pnlResults.Controls.Add(pnlPersonalInfo);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 130);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(20);
            pnlResults.Size = new Size(800, 470);
            pnlResults.TabIndex = 1;
            pnlResults.Visible = false;
            // 
            // pnlParentInfo
            // 
            pnlParentInfo.BackColor = Color.White;
            pnlParentInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlParentInfo.Controls.Add(txtParentEmail);
            pnlParentInfo.Controls.Add(lblParentEmail);
            pnlParentInfo.Controls.Add(txtParentPhone);
            pnlParentInfo.Controls.Add(lblParentPhone);
            pnlParentInfo.Controls.Add(txtParentName);
            pnlParentInfo.Controls.Add(lblParentName);
            pnlParentInfo.Location = new Point(420, 199);
            pnlParentInfo.Name = "pnlParentInfo";
            pnlParentInfo.Padding = new Padding(10);
            pnlParentInfo.Size = new Size(350, 150);
            pnlParentInfo.TabIndex = 4;
            // 
            // txtParentEmail
            // 
            txtParentEmail.BackColor = Color.FromArgb(245, 245, 245);
            txtParentEmail.BorderStyle = BorderStyle.FixedSingle;
            txtParentEmail.Font = new Font("Segoe UI", 10F);
            txtParentEmail.Location = new Point(139, 105);
            txtParentEmail.Name = "txtParentEmail";
            txtParentEmail.ReadOnly = true;
            txtParentEmail.Size = new Size(196, 30);
            txtParentEmail.TabIndex = 5;
            // 
            // lblParentEmail
            // 
            lblParentEmail.AutoSize = true;
            lblParentEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParentEmail.Location = new Point(20, 110);
            lblParentEmail.Name = "lblParentEmail";
            lblParentEmail.Size = new Size(59, 23);
            lblParentEmail.TabIndex = 4;
            lblParentEmail.Text = "Email:";
            // 
            // txtParentPhone
            // 
            txtParentPhone.BackColor = Color.FromArgb(245, 245, 245);
            txtParentPhone.BorderStyle = BorderStyle.FixedSingle;
            txtParentPhone.Font = new Font("Segoe UI", 10F);
            txtParentPhone.Location = new Point(139, 65);
            txtParentPhone.Name = "txtParentPhone";
            txtParentPhone.ReadOnly = true;
            txtParentPhone.Size = new Size(196, 30);
            txtParentPhone.TabIndex = 3;
            // 
            // lblParentPhone
            // 
            lblParentPhone.AutoSize = true;
            lblParentPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParentPhone.Location = new Point(-1, 70);
            lblParentPhone.Name = "lblParentPhone";
            lblParentPhone.Size = new Size(136, 23);
            lblParentPhone.TabIndex = 2;
            lblParentPhone.Text = "Phone Number:";
            // 
            // txtParentName
            // 
            txtParentName.BackColor = Color.FromArgb(245, 245, 245);
            txtParentName.BorderStyle = BorderStyle.FixedSingle;
            txtParentName.Font = new Font("Segoe UI", 10F);
            txtParentName.Location = new Point(139, 25);
            txtParentName.Name = "txtParentName";
            txtParentName.ReadOnly = true;
            txtParentName.Size = new Size(196, 30);
            txtParentName.TabIndex = 1;
            // 
            // lblParentName
            // 
            lblParentName.AutoSize = true;
            lblParentName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParentName.Location = new Point(-1, 30);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(119, 23);
            lblParentName.TabIndex = 0;
            lblParentName.Text = "Parent Name:";
            // 
            // pnlLocationInfo
            // 
            pnlLocationInfo.BackColor = Color.White;
            pnlLocationInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlLocationInfo.Controls.Add(txtCountry);
            pnlLocationInfo.Controls.Add(lblCountry);
            pnlLocationInfo.Controls.Add(txtCity);
            pnlLocationInfo.Controls.Add(lblCity);
            pnlLocationInfo.Controls.Add(txtLocation);
            pnlLocationInfo.Controls.Add(lblLocation);
            pnlLocationInfo.Location = new Point(30, 199);
            pnlLocationInfo.Name = "pnlLocationInfo";
            pnlLocationInfo.Padding = new Padding(10);
            pnlLocationInfo.Size = new Size(350, 150);
            pnlLocationInfo.TabIndex = 3;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.FromArgb(245, 245, 245);
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Segoe UI", 10F);
            txtCountry.Location = new Point(120, 105);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(210, 30);
            txtCountry.TabIndex = 5;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCountry.Location = new Point(20, 110);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(80, 23);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country:";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(245, 245, 245);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(120, 65);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(210, 30);
            txtCity.TabIndex = 3;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.Location = new Point(20, 70);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(47, 23);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(245, 245, 245);
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(120, 25);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(210, 30);
            txtLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(20, 30);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(79, 23);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Address:";
            // 
            // pnlAcademicInfo
            // 
            pnlAcademicInfo.BackColor = Color.White;
            pnlAcademicInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlAcademicInfo.Controls.Add(txtStage);
            pnlAcademicInfo.Controls.Add(lblStage);
            pnlAcademicInfo.Controls.Add(txtLevel);
            pnlAcademicInfo.Controls.Add(lblLevel);
            pnlAcademicInfo.Location = new Point(420, 30);
            pnlAcademicInfo.Name = "pnlAcademicInfo";
            pnlAcademicInfo.Padding = new Padding(10);
            pnlAcademicInfo.Size = new Size(350, 150);
            pnlAcademicInfo.TabIndex = 2;
            // 
            // txtStage
            // 
            txtStage.BackColor = Color.FromArgb(245, 245, 245);
            txtStage.BorderStyle = BorderStyle.FixedSingle;
            txtStage.Font = new Font("Segoe UI", 10F);
            txtStage.Location = new Point(120, 105);
            txtStage.Name = "txtStage";
            txtStage.ReadOnly = true;
            txtStage.Size = new Size(210, 30);
            txtStage.TabIndex = 3;
            // 
            // lblStage
            // 
            lblStage.AutoSize = true;
            lblStage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStage.Location = new Point(20, 110);
            lblStage.Name = "lblStage";
            lblStage.Size = new Size(61, 23);
            lblStage.TabIndex = 2;
            lblStage.Text = "Stage:";
            // 
            // txtLevel
            // 
            txtLevel.BackColor = Color.FromArgb(245, 245, 245);
            txtLevel.BorderStyle = BorderStyle.FixedSingle;
            txtLevel.Font = new Font("Segoe UI", 10F);
            txtLevel.Location = new Point(120, 30);
            txtLevel.Name = "txtLevel";
            txtLevel.ReadOnly = true;
            txtLevel.Size = new Size(210, 30);
            txtLevel.TabIndex = 1;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLevel.Location = new Point(20, 37);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(56, 23);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "Level:";
            // 
            // pnlPersonalInfo
            // 
            pnlPersonalInfo.BackColor = Color.White;
            pnlPersonalInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlPersonalInfo.Controls.Add(txtDOB);
            pnlPersonalInfo.Controls.Add(lblDOB);
            pnlPersonalInfo.Controls.Add(txtLastName);
            pnlPersonalInfo.Controls.Add(lblLastName);
            pnlPersonalInfo.Controls.Add(txtFirstName);
            pnlPersonalInfo.Controls.Add(lblFirstName);
            pnlPersonalInfo.Location = new Point(30, 30);
            pnlPersonalInfo.Name = "pnlPersonalInfo";
            pnlPersonalInfo.Padding = new Padding(10);
            pnlPersonalInfo.Size = new Size(350, 150);
            pnlPersonalInfo.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.BackColor = Color.FromArgb(245, 245, 245);
            txtDOB.BorderStyle = BorderStyle.FixedSingle;
            txtDOB.Font = new Font("Segoe UI", 10F);
            txtDOB.Location = new Point(120, 105);
            txtDOB.Name = "txtDOB";
            txtDOB.ReadOnly = true;
            txtDOB.Size = new Size(210, 30);
            txtDOB.TabIndex = 5;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDOB.Location = new Point(2, 110);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(120, 23);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "Date of Birth:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(245, 245, 245);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(120, 65);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(210, 30);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(20, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 23);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(245, 245, 245);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(120, 25);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(210, 30);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(20, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // SearchStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlResults);
            Controls.Add(pnlHeader);
            Name = "SearchStudentControl";
            Size = new Size(800, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlResults.ResumeLayout(false);
            pnlParentInfo.ResumeLayout(false);
            pnlParentInfo.PerformLayout();
            pnlLocationInfo.ResumeLayout(false);
            pnlLocationInfo.PerformLayout();
            pnlAcademicInfo.ResumeLayout(false);
            pnlAcademicInfo.PerformLayout();
            pnlPersonalInfo.ResumeLayout(false);
            pnlPersonalInfo.PerformLayout();
            ResumeLayout(false);
        }
    }
}