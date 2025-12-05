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
            //components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchPrompt = new System.Windows.Forms.Label();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.grpDetails = new System.Windows.Forms.GroupBox();

            // تهيئة العناوين والقيم
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblValueID = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblValueName = new System.Windows.Forms.Label();
            this.lblTitleSubject = new System.Windows.Forms.Label();
            this.lblValueSubject = new System.Windows.Forms.Label();
            this.lblTitleDegree = new System.Windows.Forms.Label();
            this.lblValueDegree = new System.Windows.Forms.Label();
            this.lblTitlePhone = new System.Windows.Forms.Label();
            this.lblValuePhone = new System.Windows.Forms.Label();
            this.lblTitleEmail = new System.Windows.Forms.Label();
            this.lblValueEmail = new System.Windows.Forms.Label();
            this.lblTitleSalary = new System.Windows.Forms.Label();
            this.lblValueSalary = new System.Windows.Forms.Label();
            this.lblTitleDate = new System.Windows.Forms.Label();
            this.lblValueDate = new System.Windows.Forms.Label();
            this.lblTitleAddress = new System.Windows.Forms.Label();
            this.lblValueAddress = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔍 Search Teacher";
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearchBox.Controls.Add(this.btnClear);
            this.pnlSearchBox.Controls.Add(this.btnSearch);
            this.pnlSearchBox.Controls.Add(this.txtSearch);
            this.pnlSearchBox.Controls.Add(this.lblSearchPrompt);
            this.pnlSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBox.Location = new System.Drawing.Point(0, 70);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(800, 100);
            this.pnlSearchBox.TabIndex = 1;
            // 
            // lblSearchPrompt
            // 
            this.lblSearchPrompt.AutoSize = true;
            this.lblSearchPrompt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchPrompt.Location = new System.Drawing.Point(30, 25);
            this.lblSearchPrompt.Name = "lblSearchPrompt";
            this.lblSearchPrompt.Size = new System.Drawing.Size(183, 19);
            this.lblSearchPrompt.TabIndex = 0;
            this.lblSearchPrompt.Text = "Enter Teacher ID or Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(34, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(450, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(580, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.AutoScroll = true;
            this.pnlResult.BackColor = System.Drawing.Color.White;
            this.pnlResult.Controls.Add(this.grpDetails);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 170);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Padding = new System.Windows.Forms.Padding(30);
            this.pnlResult.Size = new System.Drawing.Size(800, 430);
            this.pnlResult.TabIndex = 2;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblValueAddress);
            this.grpDetails.Controls.Add(this.lblTitleAddress);
            this.grpDetails.Controls.Add(this.lblValueDate);
            this.grpDetails.Controls.Add(this.lblTitleDate);
            this.grpDetails.Controls.Add(this.lblValueSalary);
            this.grpDetails.Controls.Add(this.lblTitleSalary);
            this.grpDetails.Controls.Add(this.lblValueEmail);
            this.grpDetails.Controls.Add(this.lblTitleEmail);
            this.grpDetails.Controls.Add(this.lblValuePhone);
            this.grpDetails.Controls.Add(this.lblTitlePhone);
            this.grpDetails.Controls.Add(this.lblValueDegree);
            this.grpDetails.Controls.Add(this.lblTitleDegree);
            this.grpDetails.Controls.Add(this.lblValueSubject);
            this.grpDetails.Controls.Add(this.lblTitleSubject);
            this.grpDetails.Controls.Add(this.lblValueName);
            this.grpDetails.Controls.Add(this.lblTitleName);
            this.grpDetails.Controls.Add(this.lblValueID);
            this.grpDetails.Controls.Add(this.lblTitleID);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpDetails.Location = new System.Drawing.Point(30, 30);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(740, 350);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Teacher Details";
            // 
            // Helper Method to Add Labels (Simulating Designer Code)
            // 

            // ID
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleID.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleID.Location = new System.Drawing.Point(30, 50);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(27, 19);
            this.lblTitleID.Text = "ID:";

            this.lblValueID.AutoSize = true;
            this.lblValueID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueID.ForeColor = System.Drawing.Color.Black;
            this.lblValueID.Location = new System.Drawing.Point(150, 50);
            this.lblValueID.Name = "lblValueID";
            this.lblValueID.Text = "---";

            // Name
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleName.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleName.Location = new System.Drawing.Point(30, 80);
            this.lblTitleName.Text = "Full Name:";

            this.lblValueName.AutoSize = true;
            this.lblValueName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueName.ForeColor = System.Drawing.Color.Black;
            this.lblValueName.Location = new System.Drawing.Point(150, 80);
            this.lblValueName.Text = "---";

            // Subject
            this.lblTitleSubject.AutoSize = true;
            this.lblTitleSubject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleSubject.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleSubject.Location = new System.Drawing.Point(30, 110);
            this.lblTitleSubject.Text = "Subject:";

            this.lblValueSubject.AutoSize = true;
            this.lblValueSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueSubject.ForeColor = System.Drawing.Color.Black;
            this.lblValueSubject.Location = new System.Drawing.Point(150, 110);
            this.lblValueSubject.Text = "---";

            // Degree
            this.lblTitleDegree.AutoSize = true;
            this.lblTitleDegree.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleDegree.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleDegree.Location = new System.Drawing.Point(30, 140);
            this.lblTitleDegree.Text = "Degree:";

            this.lblValueDegree.AutoSize = true;
            this.lblValueDegree.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueDegree.ForeColor = System.Drawing.Color.Black;
            this.lblValueDegree.Location = new System.Drawing.Point(150, 140);
            this.lblValueDegree.Text = "---";

            // Salary
            this.lblTitleSalary.AutoSize = true;
            this.lblTitleSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleSalary.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleSalary.Location = new System.Drawing.Point(400, 50);
            this.lblTitleSalary.Text = "Salary:";

            this.lblValueSalary.AutoSize = true;
            this.lblValueSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueSalary.ForeColor = System.Drawing.Color.Green;
            this.lblValueSalary.Location = new System.Drawing.Point(520, 50);
            this.lblValueSalary.Text = "---";

            // Start Date
            this.lblTitleDate.AutoSize = true;
            this.lblTitleDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleDate.Location = new System.Drawing.Point(400, 80);
            this.lblTitleDate.Text = "Start Date:";

            this.lblValueDate.AutoSize = true;
            this.lblValueDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueDate.ForeColor = System.Drawing.Color.Black;
            this.lblValueDate.Location = new System.Drawing.Point(520, 80);
            this.lblValueDate.Text = "---";

            // Phone
            this.lblTitlePhone.AutoSize = true;
            this.lblTitlePhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitlePhone.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitlePhone.Location = new System.Drawing.Point(400, 110);
            this.lblTitlePhone.Text = "Phone:";

            this.lblValuePhone.AutoSize = true;
            this.lblValuePhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValuePhone.ForeColor = System.Drawing.Color.Black;
            this.lblValuePhone.Location = new System.Drawing.Point(520, 110);
            this.lblValuePhone.Text = "---";

            // Email
            this.lblTitleEmail.AutoSize = true;
            this.lblTitleEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleEmail.Location = new System.Drawing.Point(400, 140);
            this.lblTitleEmail.Text = "Email:";

            this.lblValueEmail.AutoSize = true;
            this.lblValueEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueEmail.ForeColor = System.Drawing.Color.Black;
            this.lblValueEmail.Location = new System.Drawing.Point(520, 140);
            this.lblValueEmail.Text = "---";

            // Address
            this.lblTitleAddress.AutoSize = true;
            this.lblTitleAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleAddress.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleAddress.Location = new System.Drawing.Point(30, 200);
            this.lblTitleAddress.Text = "Address:";

            this.lblValueAddress.AutoSize = true;
            this.lblValueAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValueAddress.ForeColor = System.Drawing.Color.Black;
            this.lblValueAddress.Location = new System.Drawing.Point(150, 200);
            this.lblValueAddress.Size = new System.Drawing.Size(500, 40);
            this.lblValueAddress.Text = "---";


            // 
            // SearchTeacherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlSearchBox);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SearchTeacherControl";
            this.Size = new System.Drawing.Size(800, 600);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
