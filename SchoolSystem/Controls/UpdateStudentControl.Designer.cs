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
        private ToolTip toolTip;
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
            btnClear = new Button();
            btnSave = new Button();
            btnEditParent = new Button();
            btnEditLocation = new Button();
            btnSearch = new Button();
            dtpDob = new DateTimePicker();
            txtParentId = new TextBox();
            txtLocationId = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtStudentId = new TextBox();
            lblParent = new Label();
            lblLoc = new Label();
            lblDob = new Label();
            lblLn = new Label();
            lblFn = new Label();
            lblId = new Label();
            toolTip = new ToolTip(components);
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
            lblTitle.Size = new Size(332, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✏️ Update Student Data";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(btnEditParent);
            pnlForm.Controls.Add(btnEditLocation);
            pnlForm.Controls.Add(btnSearch);
            pnlForm.Controls.Add(dtpDob);
            pnlForm.Controls.Add(txtParentId);
            pnlForm.Controls.Add(txtLocationId);
            pnlForm.Controls.Add(txtLastName);
            pnlForm.Controls.Add(txtFirstName);
            pnlForm.Controls.Add(txtStudentId);
            pnlForm.Controls.Add(lblParent);
            pnlForm.Controls.Add(lblLoc);
            pnlForm.Controls.Add(lblDob);
            pnlForm.Controls.Add(lblLn);
            pnlForm.Controls.Add(lblFn);
            pnlForm.Controls.Add(lblId);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 88);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(30, 25, 30, 25);
            pnlForm.Size = new Size(600, 724);
            pnlForm.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(34, 462);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 18;
            lblStatus.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(370, 400);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 44);
            btnClear.TabIndex = 17;
            btnClear.Text = "🗑️ Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(34, 500);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(516, 56);
            btnSave.TabIndex = 16;
            btnSave.Text = "💾 Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEditParent
            // 
            btnEditParent.Font = new Font("Segoe UI", 9F);
            btnEditParent.Location = new Point(300, 325);
            btnEditParent.Margin = new Padding(3, 4, 3, 4);
            btnEditParent.Name = "btnEditParent";
            btnEditParent.Size = new Size(70, 42);
            btnEditParent.TabIndex = 15;
            btnEditParent.Text = "✏️ Edit";
            btnEditParent.UseVisualStyleBackColor = true;
            btnEditParent.Click += btnEditParent_Click;
            // 
            // btnEditLocation
            // 
            btnEditLocation.Font = new Font("Segoe UI", 9F);
            btnEditLocation.Location = new Point(300, 269);
            btnEditLocation.Margin = new Padding(3, 4, 3, 4);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(70, 42);
            btnEditLocation.TabIndex = 14;
            btnEditLocation.Text = "✏️ Edit";
            btnEditLocation.UseVisualStyleBackColor = true;
            btnEditLocation.Click += btnEditLocation_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.Location = new Point(300, 27);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 38);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Location = new Point(180, 206);
            dtpDob.Margin = new Padding(3, 4, 3, 4);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(293, 30);
            dtpDob.TabIndex = 12;
            // 
            // txtParentId
            // 
            txtParentId.BackColor = Color.FromArgb(250, 250, 250);
            txtParentId.Font = new Font("Segoe UI", 10F);
            txtParentId.Location = new Point(180, 331);
            txtParentId.Margin = new Padding(3, 4, 3, 4);
            txtParentId.Name = "txtParentId";
            txtParentId.ReadOnly = true;
            txtParentId.Size = new Size(110, 30);
            txtParentId.TabIndex = 11;
            // 
            // txtLocationId
            // 
            txtLocationId.BackColor = Color.FromArgb(250, 250, 250);
            txtLocationId.Font = new Font("Segoe UI", 10F);
            txtLocationId.Location = new Point(180, 281);
            txtLocationId.Margin = new Padding(3, 4, 3, 4);
            txtLocationId.Name = "txtLocationId";
            txtLocationId.ReadOnly = true;
            txtLocationId.Size = new Size(110, 30);
            txtLocationId.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(180, 156);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(370, 30);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(180, 106);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(370, 30);
            txtFirstName.TabIndex = 9;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 10F);
            txtStudentId.Location = new Point(180, 31);
            txtStudentId.Margin = new Padding(3, 4, 3, 4);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(110, 30);
            txtStudentId.TabIndex = 7;
            txtStudentId.KeyPress += txtStudentId_KeyPress;
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblParent.Location = new Point(34, 338);
            lblParent.Name = "lblParent";
            lblParent.Size = new Size(67, 23);
            lblParent.TabIndex = 6;
            lblParent.Text = "Parent:";
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLoc.Location = new Point(34, 288);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(83, 23);
            lblLoc.TabIndex = 5;
            lblLoc.Text = "Location:";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDob.Location = new Point(34, 212);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(120, 23);
            lblDob.TabIndex = 4;
            lblDob.Text = "Date of Birth:";
            // 
            // lblLn
            // 
            lblLn.AutoSize = true;
            lblLn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLn.Location = new Point(34, 162);
            lblLn.Name = "lblLn";
            lblLn.Size = new Size(99, 23);
            lblLn.TabIndex = 3;
            lblLn.Text = "Last Name:";
            // 
            // lblFn
            // 
            lblFn.AutoSize = true;
            lblFn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFn.Location = new Point(34, 112);
            lblFn.Name = "lblFn";
            lblFn.Size = new Size(90, 20);
            lblFn.TabIndex = 2;
            lblFn.Text = "First Name:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.Location = new Point(34, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(102, 23);
            lblId.TabIndex = 1;
            lblId.Text = "Student ID:";
            // 
            // UpdateStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateStudentControl";
            Size = new Size(600, 812);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}