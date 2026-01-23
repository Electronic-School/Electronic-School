namespace SchoolSystem.Controls
{
    partial class UpdateStudentControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlForm;
        private TextBox txtStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtLocationId;
        private TextBox txtParentId;
        private DateTimePicker dtpDob;
        private Button btnSearch;
        private Button btnSave;
        private Button btnEditLocation;
        private Button btnEditParent;
        private Label lblId;
        private Label lblFn;
        private Label lblLn;
        private Label lblLoc;
        private Label lblParent;
        private Label lblDob;
        private Button btnClear;
        private ComboBox cmbStudentLevel;
        private Label lblStudentLevel;

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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlForm = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            btnEditParent = new Button();
            btnEditLocation = new Button();
            btnSearch = new Button();
            cmbStudentLevel = new ComboBox();
            dtpDob = new DateTimePicker();
            txtParentId = new TextBox();
            txtLocationId = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtStudentId = new TextBox();
            lblStudentLevel = new Label();
            lblParent = new Label();
            lblLoc = new Label();
            lblDob = new Label();
            lblLn = new Label();
            lblFn = new Label();
            lblId = new Label();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(152, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Student";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(btnEditParent);
            pnlForm.Controls.Add(btnEditLocation);
            pnlForm.Controls.Add(btnSearch);
            pnlForm.Controls.Add(cmbStudentLevel);
            pnlForm.Controls.Add(dtpDob);
            pnlForm.Controls.Add(txtParentId);
            pnlForm.Controls.Add(txtLocationId);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(txtStudentId);
            pnlForm.Controls.Add(lblStudentLevel);
            pnlForm.Controls.Add(lblParent);
            pnlForm.Controls.Add(lblLoc);
            pnlForm.Controls.Add(lblDob);
            pnlForm.Controls.Add(lblLn);
            pnlForm.Controls.Add(lblFn);
            pnlForm.Controls.Add(lblId);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 20, 30, 20);
            pnlForm.Size = new Size(550, 530);
            pnlForm.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(149, 165, 166);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(370, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(33, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(487, 45);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEditParent
            // 
            btnEditParent.BackColor = Color.FromArgb(44, 62, 80);
            btnEditParent.FlatStyle = FlatStyle.Flat;
            btnEditParent.Font = new Font("Segoe UI", 9F);
            btnEditParent.ForeColor = Color.White;
            btnEditParent.Location = new Point(270, 340);
            btnEditParent.Name = "btnEditParent";
            btnEditParent.Size = new Size(70, 32);
            btnEditParent.TabIndex = 15;
            btnEditParent.Text = "Edit";
            btnEditParent.UseVisualStyleBackColor = false;
            btnEditParent.Click += btnEditParent_Click;
            // 
            // btnEditLocation
            // 
            btnEditLocation.BackColor = Color.FromArgb(44, 62, 80);
            btnEditLocation.FlatStyle = FlatStyle.Flat;
            btnEditLocation.Font = new Font("Segoe UI", 9F);
            btnEditLocation.ForeColor = Color.White;
            btnEditLocation.Location = new Point(270, 290);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(70, 32);
            btnEditLocation.TabIndex = 14;
            btnEditLocation.Text = "Edit";
            btnEditLocation.UseVisualStyleBackColor = false;
            btnEditLocation.Click += btnEditLocation_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(44, 62, 80);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(270, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 32);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbStudentLevel
            // 
            cmbStudentLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentLevel.Font = new Font("Segoe UI", 10F);
            cmbStudentLevel.FormattingEnabled = true;
            cmbStudentLevel.Location = new Point(170, 190);
            cmbStudentLevel.Name = "cmbStudentLevel";
            cmbStudentLevel.Size = new Size(250, 25);
            cmbStudentLevel.TabIndex = 12;
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(170, 235);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(250, 25);
            dtpDob.TabIndex = 12;
            // 
            // txtParentId
            // 
            txtParentId.BackColor = Color.FromArgb(250, 250, 250);
            txtParentId.Font = new Font("Segoe UI", 10F);
            txtParentId.Location = new Point(170, 340);
            txtParentId.Name = "txtParentId";
            txtParentId.ReadOnly = true;
            txtParentId.Size = new Size(90, 25);
            txtParentId.TabIndex = 11;
            // 
            // txtLocationId
            // 
            txtLocationId.BackColor = Color.FromArgb(250, 250, 250);
            txtLocationId.Font = new Font("Segoe UI", 10F);
            txtLocationId.Location = new Point(170, 290);
            txtLocationId.Name = "txtLocationId";
            txtLocationId.ReadOnly = true;
            txtLocationId.Size = new Size(90, 25);
            txtLocationId.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(170, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(350, 25);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(170, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(350, 25);
            txtFirstName.TabIndex = 8;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 10F);
            txtStudentId.Location = new Point(170, 25);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(90, 25);
            txtStudentId.TabIndex = 7;
            txtStudentId.KeyPress += txtStudentId_KeyPress;
            // 
            // lblStudentLevel
            // 
            lblStudentLevel.AutoSize = true;
            lblStudentLevel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentLevel.Location = new Point(33, 195);
            lblStudentLevel.Name = "lblStudentLevel";
            lblStudentLevel.Size = new Size(101, 19);
            lblStudentLevel.TabIndex = 6;
            lblStudentLevel.Text = "Student Level:";
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParent.Location = new Point(33, 345);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(53, 19);
            lblParent.TabIndex = 5;
            lblParent.Text = "Parent:";
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLoc.Location = new Point(33, 295);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(67, 19);
            lblLoc.TabIndex = 4;
            lblLoc.Text = "Location:";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDob.Location = new Point(33, 240);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 19);
            lblDob.TabIndex = 3;
            lblDob.Text = "Date of Birth:";
            // 
            // lblLn
            // 
            lblLn.AutoSize = true;
            lblLn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLn.Location = new Point(33, 150);
            lblLn.Name = "lblLn";
            lblLn.Size = new Size(79, 19);
            lblLn.TabIndex = 2;
            lblLn.Text = "Last Name:";
            // 
            // lblFn
            // 
            lblFn.AutoSize = true;
            lblFn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFn.Location = new Point(33, 100);
            lblFn.Name = "lblFn";
            lblFn.Size = new Size(81, 19);
            lblFn.TabIndex = 1;
            lblFn.Text = "First Name:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.Location = new Point(33, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(78, 19);
            lblId.TabIndex = 0;
            lblId.Text = "Student ID:";
            // 
            // UpdateStudentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Name = "UpdateStudentControl";
            Size = new Size(550, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}