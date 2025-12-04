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
        private PictureBox picStudent;
        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDOB;
        private Label lblLocation;
        private Label lblCity;
        private Label lblCountry;
        private Label lblParentName;
        private Label lblParentPhone;
        private Label lblParentEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDOB;
        private TextBox txtLocation;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtParentName;
        private TextBox txtParentPhone;
        private TextBox txtParentEmail;
        private Label lblStatus;
        private GroupBox gbPersonalInfo;
        private GroupBox gbLocationInfo;
        private GroupBox gbParentInfo;
        private ToolTip toolTip;
        private Button btnExport;

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
            btnExport = new Button();
            lblStatus = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            lblTitle = new Label();
            pnlResults = new Panel();
            gbParentInfo = new GroupBox();
            txtParentEmail = new TextBox();
            lblParentEmail = new Label();
            txtParentPhone = new TextBox();
            lblParentPhone = new Label();
            txtParentName = new TextBox();
            lblParentName = new Label();
            gbLocationInfo = new GroupBox();
            txtCountry = new TextBox();
            lblCountry = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtLocation = new TextBox();
            lblLocation = new Label();
            gbPersonalInfo = new GroupBox();
            txtDOB = new TextBox();
            lblDOB = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            picStudent = new PictureBox();
            toolTip = new ToolTip(components);
            pnlHeader.SuspendLayout();
            pnlResults.SuspendLayout();
            gbParentInfo.SuspendLayout();
            gbLocationInfo.SuspendLayout();
            gbPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(btnExport);
            pnlHeader.Controls.Add(lblStatus);
            pnlHeader.Controls.Add(btnClear);
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(txtStudentID);
            pnlHeader.Controls.Add(lblStudentID);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 111);
            pnlHeader.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.Enabled = false;
            btnExport.Font = new Font("Segoe UI", 10F);
            btnExport.Location = new Point(550, 50);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 39);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export to Text";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(120, 85);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(227, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Enter Student ID and click Search";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(400, 50);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 39);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.Location = new Point(290, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 10F);
            txtStudentID.Location = new Point(120, 52);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(150, 30);
            txtStudentID.TabIndex = 1;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            txtStudentID.KeyPress += txtStudentID_KeyPress;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 10F);
            lblStudentID.ForeColor = Color.White;
            lblStudentID.Location = new Point(20, 55);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(95, 23);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔍 Search Student";
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(gbParentInfo);
            pnlResults.Controls.Add(gbLocationInfo);
            pnlResults.Controls.Add(gbPersonalInfo);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(0, 111);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(20);
            pnlResults.Size = new Size(800, 489);
            pnlResults.TabIndex = 1;
            pnlResults.Visible = false;
            // 
            // gbParentInfo
            // 
            gbParentInfo.Controls.Add(txtParentEmail);
            gbParentInfo.Controls.Add(lblParentEmail);
            gbParentInfo.Controls.Add(txtParentPhone);
            gbParentInfo.Controls.Add(lblParentPhone);
            gbParentInfo.Controls.Add(txtParentName);
            gbParentInfo.Controls.Add(lblParentName);
            gbParentInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbParentInfo.Location = new Point(30, 340);
            gbParentInfo.Name = "gbParentInfo";
            gbParentInfo.Size = new Size(600, 140);
            gbParentInfo.TabIndex = 2;
            gbParentInfo.TabStop = false;
            gbParentInfo.Text = "Parent Information";
            // 
            // txtParentEmail
            // 
            txtParentEmail.BackColor = Color.FromArgb(236, 240, 241);
            txtParentEmail.BorderStyle = BorderStyle.None;
            txtParentEmail.Font = new Font("Segoe UI", 10F);
            txtParentEmail.Location = new Point(150, 111);
            txtParentEmail.Name = "txtParentEmail";
            txtParentEmail.ReadOnly = true;
            txtParentEmail.Size = new Size(250, 23);
            txtParentEmail.TabIndex = 5;
            // 
            // lblParentEmail
            // 
            lblParentEmail.AutoSize = true;
            lblParentEmail.Font = new Font("Segoe UI", 10F);
            lblParentEmail.Location = new Point(20, 111);
            lblParentEmail.Name = "lblParentEmail";
            lblParentEmail.Size = new Size(55, 23);
            lblParentEmail.TabIndex = 4;
            lblParentEmail.Text = "Email:";
            // 
            // txtParentPhone
            // 
            txtParentPhone.BackColor = Color.FromArgb(236, 240, 241);
            txtParentPhone.BorderStyle = BorderStyle.None;
            txtParentPhone.Font = new Font("Segoe UI", 10F);
            txtParentPhone.Location = new Point(150, 75);
            txtParentPhone.Name = "txtParentPhone";
            txtParentPhone.ReadOnly = true;
            txtParentPhone.Size = new Size(250, 23);
            txtParentPhone.TabIndex = 3;
            // 
            // lblParentPhone
            // 
            lblParentPhone.AutoSize = true;
            lblParentPhone.Font = new Font("Segoe UI", 10F);
            lblParentPhone.Location = new Point(20, 75);
            lblParentPhone.Name = "lblParentPhone";
            lblParentPhone.Size = new Size(131, 23);
            lblParentPhone.TabIndex = 2;
            lblParentPhone.Text = "Phone Number:";
            // 
            // txtParentName
            // 
            txtParentName.BackColor = Color.FromArgb(236, 240, 241);
            txtParentName.BorderStyle = BorderStyle.None;
            txtParentName.Font = new Font("Segoe UI", 10F);
            txtParentName.Location = new Point(150, 40);
            txtParentName.Name = "txtParentName";
            txtParentName.ReadOnly = true;
            txtParentName.Size = new Size(400, 23);
            txtParentName.TabIndex = 1;
            // 
            // lblParentName
            // 
            lblParentName.AutoSize = true;
            lblParentName.Font = new Font("Segoe UI", 10F);
            lblParentName.Location = new Point(20, 40);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(114, 23);
            lblParentName.TabIndex = 0;
            lblParentName.Text = "Parent Name:";
            // 
            // gbLocationInfo
            // 
            gbLocationInfo.Controls.Add(txtCountry);
            gbLocationInfo.Controls.Add(lblCountry);
            gbLocationInfo.Controls.Add(txtCity);
            gbLocationInfo.Controls.Add(lblCity);
            gbLocationInfo.Controls.Add(txtLocation);
            gbLocationInfo.Controls.Add(lblLocation);
            gbLocationInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbLocationInfo.Location = new Point(30, 200);
            gbLocationInfo.Name = "gbLocationInfo";
            gbLocationInfo.Size = new Size(600, 120);
            gbLocationInfo.TabIndex = 1;
            gbLocationInfo.TabStop = false;
            gbLocationInfo.Text = "Location Information";
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.FromArgb(236, 240, 241);
            txtCountry.BorderStyle = BorderStyle.None;
            txtCountry.Font = new Font("Segoe UI", 10F);
            txtCountry.Location = new Point(500, 75);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(250, 23);
            txtCountry.TabIndex = 5;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 10F);
            lblCountry.Location = new Point(420, 75);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(75, 23);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country:";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(236, 240, 241);
            txtCity.BorderStyle = BorderStyle.None;
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(150, 75);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(250, 23);
            txtCity.TabIndex = 3;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F);
            lblCity.Location = new Point(20, 75);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(43, 23);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(236, 240, 241);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(150, 40);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(400, 23);
            txtLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10F);
            lblLocation.Location = new Point(20, 40);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(74, 23);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Address:";
            // 
            // gbPersonalInfo
            // 
            gbPersonalInfo.Controls.Add(txtDOB);
            gbPersonalInfo.Controls.Add(lblDOB);
            gbPersonalInfo.Controls.Add(txtLastName);
            gbPersonalInfo.Controls.Add(lblLastName);
            gbPersonalInfo.Controls.Add(txtFirstName);
            gbPersonalInfo.Controls.Add(lblFirstName);
            gbPersonalInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPersonalInfo.Location = new Point(30, 30);
            gbPersonalInfo.Name = "gbPersonalInfo";
            gbPersonalInfo.Size = new Size(600, 150);
            gbPersonalInfo.TabIndex = 0;
            gbPersonalInfo.TabStop = false;
            gbPersonalInfo.Text = "Personal Information";
            // 
            // txtDOB
            // 
            txtDOB.BackColor = Color.FromArgb(236, 240, 241);
            txtDOB.BorderStyle = BorderStyle.None;
            txtDOB.Font = new Font("Segoe UI", 10F);
            txtDOB.Location = new Point(150, 110);
            txtDOB.Name = "txtDOB";
            txtDOB.ReadOnly = true;
            txtDOB.Size = new Size(200, 23);
            txtDOB.TabIndex = 5;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 10F);
            lblDOB.Location = new Point(20, 110);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(111, 23);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "Date of Birth:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(236, 240, 241);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(150, 75);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(400, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.Location = new Point(20, 75);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(236, 240, 241);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(150, 40);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(400, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.Location = new Point(20, 40);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // picStudent
            // 
            picStudent.Location = new Point(0, 0);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(100, 50);
            picStudent.TabIndex = 0;
            picStudent.TabStop = false;
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
            gbParentInfo.ResumeLayout(false);
            gbParentInfo.PerformLayout();
            gbLocationInfo.ResumeLayout(false);
            gbLocationInfo.PerformLayout();
            gbPersonalInfo.ResumeLayout(false);
            gbPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
        }
    }
}