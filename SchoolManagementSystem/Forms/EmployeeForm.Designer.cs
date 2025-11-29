namespace SchoolManagementSystem.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage4 = new TabPage();
            panel2 = new Panel();
            dgvEmployees = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            btnNext2 = new Button();
            cmbStatus = new ComboBox();
            dtpHireDate = new DateTimePicker();
            txtSalary = new TextBox();
            txtDepartment = new TextBox();
            txtJobTitle = new TextBox();
            label5 = new Label();
            lblSalary = new Label();
            lblHireDate = new Label();
            lblDepartment = new Label();
            lblIobTitle = new Label();
            tabPage1 = new TabPage();
            btnNext1 = new Button();
            dtpBirth = new DateTimePicker();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            lblAge = new Label();
            lblBirth = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblLName = new Label();
            lblFName = new Label();
            tabControl1 = new TabControl();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnClear = new Button();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(780, 368);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Employees Table";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvEmployees);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 367);
            panel2.TabIndex = 0;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(0, 50);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(774, 317);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(194, 50);
            label1.TabIndex = 0;
            label1.Text = "Employees Table";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(780, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Job Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNext2);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(dtpHireDate);
            panel1.Controls.Add(txtSalary);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(txtJobTitle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblSalary);
            panel1.Controls.Add(lblHireDate);
            panel1.Controls.Add(lblDepartment);
            panel1.Controls.Add(lblIobTitle);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 367);
            panel1.TabIndex = 0;
            // 
            // btnNext2
            // 
            btnNext2.Location = new Point(50, 250);
            btnNext2.Name = "btnNext2";
            btnNext2.Size = new Size(75, 23);
            btnNext2.TabIndex = 10;
            btnNext2.Text = "Next";
            btnNext2.UseVisualStyleBackColor = true;
            btnNext2.Click += btnNext2_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(100, 198);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 9;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(99, 115);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(200, 23);
            dtpHireDate.TabIndex = 8;
            dtpHireDate.ValueChanged += dtpHireDate_ValueChanged;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(100, 163);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 7;
            txtSalary.TextChanged += txtSalary_TextChanged;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(99, 78);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(100, 23);
            txtDepartment.TabIndex = 6;
            txtDepartment.TextChanged += txtDepartment_TextChanged;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(99, 40);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(100, 23);
            txtJobTitle.TabIndex = 5;
            txtJobTitle.TextChanged += txtJobTitle_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 204);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Status :";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(7, 166);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(44, 15);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary :";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(7, 121);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(62, 15);
            lblHireDate.TabIndex = 2;
            lblHireDate.Text = "Hire Date :";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(7, 78);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(79, 15);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Department : ";
            // 
            // lblIobTitle
            // 
            lblIobTitle.AutoSize = true;
            lblIobTitle.Location = new Point(7, 36);
            lblIobTitle.Name = "lblIobTitle";
            lblIobTitle.Size = new Size(56, 15);
            lblIobTitle.TabIndex = 0;
            lblIobTitle.Text = "Job Title :";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNext1);
            tabPage1.Controls.Add(dtpBirth);
            tabPage1.Controls.Add(txtAge);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtLName);
            tabPage1.Controls.Add(txtFName);
            tabPage1.Controls.Add(lblAge);
            tabPage1.Controls.Add(lblBirth);
            tabPage1.Controls.Add(lblAddress);
            tabPage1.Controls.Add(lblPhone);
            tabPage1.Controls.Add(lblEmail);
            tabPage1.Controls.Add(lblLName);
            tabPage1.Controls.Add(lblFName);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(780, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext1
            // 
            btnNext1.Location = new Point(70, 335);
            btnNext1.Name = "btnNext1";
            btnNext1.Size = new Size(75, 23);
            btnNext1.TabIndex = 14;
            btnNext1.Text = "Next";
            btnNext1.UseVisualStyleBackColor = true;
            btnNext1.Click += btnNaet_Click;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(125, 251);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(157, 23);
            dtpBirth.TabIndex = 13;
            dtpBirth.ValueChanged += dtpBirth_ValueChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(125, 296);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 12;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(125, 212);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 11;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(126, 164);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 10;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(125, 70);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 23);
            txtLName.TabIndex = 8;
            txtLName.TextChanged += txtLName_TextChanged;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(126, 27);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 7;
            txtFName.TextChanged += txtFName_TextChanged;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(12, 299);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 15);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age :";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(8, 257);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(82, 15);
            lblBirth.TabIndex = 5;
            lblBirth.Text = "Date of Birth : ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(8, 215);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(8, 167);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(94, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone Number :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(8, 117);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email :";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(8, 73);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(72, 15);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last Name : ";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(8, 30);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(70, 15);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 396);
            tabControl1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(262, 401);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(179, 425);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add New Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(351, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Employee";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(512, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 405);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(130, 15);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search  by Name or ID :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 402);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(656, 426);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(tabControl1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            tabPage4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage2;
        private Panel panel1;
        private Button btnNext2;
        private ComboBox cmbStatus;
        private DateTimePicker dtpHireDate;
        private TextBox txtSalary;
        private TextBox txtDepartment;
        private TextBox txtJobTitle;
        private Label label5;
        private Label lblSalary;
        private Label lblHireDate;
        private Label lblDepartment;
        private Label lblIobTitle;
        private TabPage tabPage1;
        private Button btnNext1;
        private DateTimePicker dtpBirth;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLName;
        private TextBox txtFName;
        private Label lblAge;
        private Label lblBirth;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblLName;
        private Label lblFName;
        private TabControl tabControl1;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvEmployees;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnClear;
    }
}