namespace SchoolManagementSystem.Controls
{
    partial class EditStudentControl
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

        private void InitializeComponent()
        {
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            btnLoad = new Button();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtLocationId = new TextBox();
            lblLocationId = new Label();
            txtParentId = new TextBox();
            lblParentId = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(467, 88);
            txtStudentId.Margin = new Padding(4, 5, 4, 5);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(199, 27);
            txtStudentId.TabIndex = 1;
            txtStudentId.KeyPress += txtStudentId_KeyPress;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(733, 92);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(83, 20);
            lblStudentId.TabIndex = 1;
            lblStudentId.Text = "رقم الطالب:";
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
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(467, 149);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(239, 27);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(733, 154);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(82, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "الاسم الأول:";
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(467, 211);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(239, 27);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(733, 215);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "الاسم الأخير:";
            // 
            // txtLocationId
            // 
            txtLocationId.Enabled = false;
            txtLocationId.Location = new Point(467, 272);
            txtLocationId.Margin = new Padding(4, 5, 4, 5);
            txtLocationId.Name = "txtLocationId";
            txtLocationId.Size = new Size(239, 27);
            txtLocationId.TabIndex = 5;
            txtLocationId.KeyPress += txtLocationId_KeyPress;
            // 
            // lblLocationId
            // 
            lblLocationId.AutoSize = true;
            lblLocationId.Location = new Point(733, 277);
            lblLocationId.Margin = new Padding(4, 0, 4, 0);
            lblLocationId.Name = "lblLocationId";
            lblLocationId.Size = new Size(81, 20);
            lblLocationId.TabIndex = 7;
            lblLocationId.Text = "رقم الموقع:";
            // 
            // txtParentId
            // 
            txtParentId.Enabled = false;
            txtParentId.Location = new Point(467, 334);
            txtParentId.Margin = new Padding(4, 5, 4, 5);
            txtParentId.Name = "txtParentId";
            txtParentId.Size = new Size(239, 27);
            txtParentId.TabIndex = 6;
            txtParentId.KeyPress += txtParentId_KeyPress;
            // 
            // lblParentId
            // 
            lblParentId.AutoSize = true;
            lblParentId.Location = new Point(733, 338);
            lblParentId.Margin = new Padding(4, 0, 4, 0);
            lblParentId.Name = "lblParentId";
            lblParentId.Size = new Size(65, 20);
            lblParentId.TabIndex = 9;
            lblParentId.Text = "رقم الأب:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(560, 415);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 54);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "تحديث البيانات";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Enabled = false;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(387, 415);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 54);
            btnClear.TabIndex = 8;
            btnClear.Text = "مسح الكل";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblTitle.Location = new Point(467, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تعديل بيانات طالب";
            // 
            // EditStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtParentId);
            Controls.Add(lblParentId);
            Controls.Add(txtLocationId);
            Controls.Add(lblLocationId);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnLoad);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditStudentControl";
            Size = new Size(1067, 769);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.TextBox txtParentId;
        private System.Windows.Forms.Label lblParentId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
    }
}