namespace SchoolSystem.Controls
{
    partial class SearchTeacherControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // header Elements 
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        // Search Elements
        private System.Windows.Forms.Panel pnlSearchBox;
        private System.Windows.Forms.Label lblSearchPrompt;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;

        // Result Elements
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.GroupBox grpDetails;

        // Labels for Titles
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblTitleSubject;
        private System.Windows.Forms.Label lblTitleDegree;
        private System.Windows.Forms.Label lblTitlePhone;
        private System.Windows.Forms.Label lblTitleEmail;
        private System.Windows.Forms.Label lblTitleSalary;
        private System.Windows.Forms.Label lblTitleDate;
        private System.Windows.Forms.Label lblTitleAddress;

        // Labels for Values
        private System.Windows.Forms.Label lblValueID;
        private System.Windows.Forms.Label lblValueName;
        private System.Windows.Forms.Label lblValueSubject;
        private System.Windows.Forms.Label lblValueDegree;
        private System.Windows.Forms.Label lblValuePhone;
        private System.Windows.Forms.Label lblValueEmail;
        private System.Windows.Forms.Label lblValueSalary;
        private System.Windows.Forms.Label lblValueDate;
        private System.Windows.Forms.Label lblValueAddress;
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
            pnlSearchBox = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearchPrompt = new Label();
            pnlResult = new Panel();
            grpDetails = new GroupBox();
            lblValueAddress = new Label();
            lblTitleAddress = new Label();
            lblValueDate = new Label();
            lblTitleDate = new Label();
            lblValueSalary = new Label();
            lblTitleSalary = new Label();
            lblValueEmail = new Label();
            lblTitleEmail = new Label();
            lblValuePhone = new Label();
            lblTitlePhone = new Label();
            lblValueDegree = new Label();
            lblTitleDegree = new Label();
            lblValueSubject = new Label();
            lblTitleSubject = new Label();
            lblValueName = new Label();
            lblTitleName = new Label();
            lblValueID = new Label();
            lblTitleID = new Label();
            pnlHeader.SuspendLayout();
            pnlSearchBox.SuspendLayout();
            pnlResult.SuspendLayout();
            grpDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔍 Search Teacher";
            // 
            // pnlSearchBox
            // 
            pnlSearchBox.BackColor = Color.WhiteSmoke;
            pnlSearchBox.Controls.Add(btnClear);
            pnlSearchBox.Controls.Add(btnSearch);
            pnlSearchBox.Controls.Add(txtSearch);
            pnlSearchBox.Controls.Add(lblSearchPrompt);
            pnlSearchBox.Dock = DockStyle.Top;
            pnlSearchBox.Location = new Point(0, 70);
            pnlSearchBox.Name = "pnlSearchBox";
            pnlSearchBox.Size = new Size(800, 100);
            pnlSearchBox.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(580, 48);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.Location = new Point(450, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(34, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 32);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            // 
            // lblSearchPrompt
            // 
            lblSearchPrompt.AutoSize = true;
            lblSearchPrompt.Font = new Font("Segoe UI", 10F);
            lblSearchPrompt.Location = new Point(30, 25);
            lblSearchPrompt.Name = "lblSearchPrompt";
            lblSearchPrompt.Size = new Size(211, 23);
            lblSearchPrompt.TabIndex = 0;
            lblSearchPrompt.Text = "Enter Teacher ID or Name:";
            // 
            // pnlResult
            // 
            pnlResult.AutoScroll = true;
            pnlResult.BackColor = Color.White;
            pnlResult.Controls.Add(grpDetails);
            pnlResult.Dock = DockStyle.Fill;
            pnlResult.Location = new Point(0, 170);
            pnlResult.Name = "pnlResult";
            pnlResult.Padding = new Padding(30);
            pnlResult.Size = new Size(800, 430);
            pnlResult.TabIndex = 2;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblValueAddress);
            grpDetails.Controls.Add(lblTitleAddress);
            grpDetails.Controls.Add(lblValueDate);
            grpDetails.Controls.Add(lblTitleDate);
            grpDetails.Controls.Add(lblValueSalary);
            grpDetails.Controls.Add(lblTitleSalary);
            grpDetails.Controls.Add(lblValueEmail);
            grpDetails.Controls.Add(lblTitleEmail);
            grpDetails.Controls.Add(lblValuePhone);
            grpDetails.Controls.Add(lblTitlePhone);
            grpDetails.Controls.Add(lblValueDegree);
            grpDetails.Controls.Add(lblTitleDegree);
            grpDetails.Controls.Add(lblValueSubject);
            grpDetails.Controls.Add(lblTitleSubject);
            grpDetails.Controls.Add(lblValueName);
            grpDetails.Controls.Add(lblTitleName);
            grpDetails.Controls.Add(lblValueID);
            grpDetails.Controls.Add(lblTitleID);
            grpDetails.Dock = DockStyle.Top;
            grpDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDetails.ForeColor = Color.FromArgb(41, 128, 185);
            grpDetails.Location = new Point(30, 30);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(740, 350);
            grpDetails.TabIndex = 0;
            grpDetails.TabStop = false;
            grpDetails.Text = "Teacher Details";
            // 
            // lblValueAddress
            // 
            lblValueAddress.AutoSize = true;
            lblValueAddress.Font = new Font("Segoe UI", 10F);
            lblValueAddress.ForeColor = Color.Black;
            lblValueAddress.Location = new Point(150, 200);
            lblValueAddress.Name = "lblValueAddress";
            lblValueAddress.Size = new Size(31, 23);
            lblValueAddress.TabIndex = 0;
            lblValueAddress.Text = "---";
            // 
            // lblTitleAddress
            // 
            lblTitleAddress.AutoSize = true;
            lblTitleAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleAddress.ForeColor = Color.DimGray;
            lblTitleAddress.Location = new Point(30, 200);
            lblTitleAddress.Name = "lblTitleAddress";
            lblTitleAddress.Size = new Size(79, 23);
            lblTitleAddress.TabIndex = 1;
            lblTitleAddress.Text = "Address:";
            // 
            // lblValueDate
            // 
            lblValueDate.AutoSize = true;
            lblValueDate.Font = new Font("Segoe UI", 10F);
            lblValueDate.ForeColor = Color.Black;
            lblValueDate.Location = new Point(520, 80);
            lblValueDate.Name = "lblValueDate";
            lblValueDate.Size = new Size(31, 23);
            lblValueDate.TabIndex = 2;
            lblValueDate.Text = "---";
            // 
            // lblTitleDate
            // 
            lblTitleDate.AutoSize = true;
            lblTitleDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleDate.ForeColor = Color.DimGray;
            lblTitleDate.Location = new Point(400, 80);
            lblTitleDate.Name = "lblTitleDate";
            lblTitleDate.Size = new Size(98, 23);
            lblTitleDate.TabIndex = 3;
            lblTitleDate.Text = "Start Date:";
            // 
            // lblValueSalary
            // 
            lblValueSalary.AutoSize = true;
            lblValueSalary.Font = new Font("Segoe UI", 10F);
            lblValueSalary.ForeColor = Color.Green;
            lblValueSalary.Location = new Point(520, 50);
            lblValueSalary.Name = "lblValueSalary";
            lblValueSalary.Size = new Size(31, 23);
            lblValueSalary.TabIndex = 4;
            lblValueSalary.Text = "---";
            // 
            // lblTitleSalary
            // 
            lblTitleSalary.AutoSize = true;
            lblTitleSalary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleSalary.ForeColor = Color.DimGray;
            lblTitleSalary.Location = new Point(400, 50);
            lblTitleSalary.Name = "lblTitleSalary";
            lblTitleSalary.Size = new Size(65, 23);
            lblTitleSalary.TabIndex = 5;
            lblTitleSalary.Text = "Salary:";
            // 
            // lblValueEmail
            // 
            lblValueEmail.AutoSize = true;
            lblValueEmail.Font = new Font("Segoe UI", 10F);
            lblValueEmail.ForeColor = Color.Black;
            lblValueEmail.Location = new Point(520, 140);
            lblValueEmail.Name = "lblValueEmail";
            lblValueEmail.Size = new Size(31, 23);
            lblValueEmail.TabIndex = 6;
            lblValueEmail.Text = "---";
            // 
            // lblTitleEmail
            // 
            lblTitleEmail.AutoSize = true;
            lblTitleEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleEmail.ForeColor = Color.DimGray;
            lblTitleEmail.Location = new Point(400, 140);
            lblTitleEmail.Name = "lblTitleEmail";
            lblTitleEmail.Size = new Size(59, 23);
            lblTitleEmail.TabIndex = 7;
            lblTitleEmail.Text = "Email:";
            // 
            // lblValuePhone
            // 
            lblValuePhone.AutoSize = true;
            lblValuePhone.Font = new Font("Segoe UI", 10F);
            lblValuePhone.ForeColor = Color.Black;
            lblValuePhone.Location = new Point(520, 110);
            lblValuePhone.Name = "lblValuePhone";
            lblValuePhone.Size = new Size(31, 23);
            lblValuePhone.TabIndex = 8;
            lblValuePhone.Text = "---";
            // 
            // lblTitlePhone
            // 
            lblTitlePhone.AutoSize = true;
            lblTitlePhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitlePhone.ForeColor = Color.DimGray;
            lblTitlePhone.Location = new Point(400, 110);
            lblTitlePhone.Name = "lblTitlePhone";
            lblTitlePhone.Size = new Size(64, 23);
            lblTitlePhone.TabIndex = 9;
            lblTitlePhone.Text = "Phone:";
            // 
            // lblValueDegree
            // 
            lblValueDegree.AutoSize = true;
            lblValueDegree.Font = new Font("Segoe UI", 10F);
            lblValueDegree.ForeColor = Color.Black;
            lblValueDegree.Location = new Point(150, 140);
            lblValueDegree.Name = "lblValueDegree";
            lblValueDegree.Size = new Size(31, 23);
            lblValueDegree.TabIndex = 10;
            lblValueDegree.Text = "---";
            // 
            // lblTitleDegree
            // 
            lblTitleDegree.AutoSize = true;
            lblTitleDegree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleDegree.ForeColor = Color.DimGray;
            lblTitleDegree.Location = new Point(30, 140);
            lblTitleDegree.Name = "lblTitleDegree";
            lblTitleDegree.Size = new Size(73, 23);
            lblTitleDegree.TabIndex = 11;
            lblTitleDegree.Text = "Degree:";
            // 
            // lblValueSubject
            // 
            lblValueSubject.AutoSize = true;
            lblValueSubject.Font = new Font("Segoe UI", 10F);
            lblValueSubject.ForeColor = Color.Black;
            lblValueSubject.Location = new Point(150, 110);
            lblValueSubject.Name = "lblValueSubject";
            lblValueSubject.Size = new Size(31, 23);
            lblValueSubject.TabIndex = 12;
            lblValueSubject.Text = "---";
            // 
            // lblTitleSubject
            // 
            lblTitleSubject.AutoSize = true;
            lblTitleSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleSubject.ForeColor = Color.DimGray;
            lblTitleSubject.Location = new Point(30, 110);
            lblTitleSubject.Name = "lblTitleSubject";
            lblTitleSubject.Size = new Size(75, 23);
            lblTitleSubject.TabIndex = 13;
            lblTitleSubject.Text = "Subject:";
            // 
            // lblValueName
            // 
            lblValueName.AutoSize = true;
            lblValueName.Font = new Font("Segoe UI", 10F);
            lblValueName.ForeColor = Color.Black;
            lblValueName.Location = new Point(150, 80);
            lblValueName.Name = "lblValueName";
            lblValueName.Size = new Size(31, 23);
            lblValueName.TabIndex = 14;
            lblValueName.Text = "---";
            // 
            // lblTitleName
            // 
            lblTitleName.AutoSize = true;
            lblTitleName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleName.ForeColor = Color.DimGray;
            lblTitleName.Location = new Point(30, 80);
            lblTitleName.Name = "lblTitleName";
            lblTitleName.Size = new Size(96, 23);
            lblTitleName.TabIndex = 15;
            lblTitleName.Text = "Full Name:";
            // 
            // lblValueID
            // 
            lblValueID.AutoSize = true;
            lblValueID.Font = new Font("Segoe UI", 10F);
            lblValueID.ForeColor = Color.Black;
            lblValueID.Location = new Point(150, 50);
            lblValueID.Name = "lblValueID";
            lblValueID.Size = new Size(31, 23);
            lblValueID.TabIndex = 16;
            lblValueID.Text = "---";
            // 
            // lblTitleID
            // 
            lblTitleID.AutoSize = true;
            lblTitleID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleID.ForeColor = Color.DimGray;
            lblTitleID.Location = new Point(30, 50);
            lblTitleID.Name = "lblTitleID";
            lblTitleID.Size = new Size(33, 23);
            lblTitleID.TabIndex = 17;
            lblTitleID.Text = "ID:";
            // 
            // SearchTeacherControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlResult);
            Controls.Add(pnlSearchBox);
            Controls.Add(pnlHeader);
            Name = "SearchTeacherControl";
            Size = new Size(800, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearchBox.ResumeLayout(false);
            pnlSearchBox.PerformLayout();
            pnlResult.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
