namespace SchoolSystem.Controls
{
    partial class AddTeacherControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            DateDateOfBirth = new Label();
            lblSalary = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtSalary = new TextBox();
            dateTDateOfBirth = new DateTimePicker();
            textBox1 = new TextBox();
            lblEducationDegree = new Label();
            cmbEducationDegree = new ComboBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(61, 63);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(61, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // DateDateOfBirth
            // 
            DateDateOfBirth.AutoSize = true;
            DateDateOfBirth.Location = new Point(61, 184);
            DateDateOfBirth.Name = "DateDateOfBirth";
            DateDateOfBirth.Size = new Size(94, 20);
            DateDateOfBirth.TabIndex = 2;
            DateDateOfBirth.Text = "Date of birth";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(61, 242);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(49, 20);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary";
            lblSalary.Click += label4_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(61, 143);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(61, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(61, 265);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 7;
            // 
            // dateTDateOfBirth
            // 
            dateTDateOfBirth.Location = new Point(61, 207);
            dateTDateOfBirth.Name = "dateTDateOfBirth";
            dateTDateOfBirth.Size = new Size(186, 27);
            dateTDateOfBirth.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 376);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 10;
            // 
            // lblEducationDegree
            // 
            lblEducationDegree.AutoSize = true;
            lblEducationDegree.Location = new Point(61, 320);
            lblEducationDegree.Name = "lblEducationDegree";
            lblEducationDegree.Size = new Size(126, 20);
            lblEducationDegree.TabIndex = 9;
            lblEducationDegree.Text = "Education degree";
            // 
            // cmbEducationDegree
            // 
            cmbEducationDegree.FormattingEnabled = true;
            cmbEducationDegree.Items.AddRange(new object[] { "Bachaler ", "Master " });
            cmbEducationDegree.Location = new Point(61, 343);
            cmbEducationDegree.Name = "cmbEducationDegree";
            cmbEducationDegree.Size = new Size(151, 28);
            cmbEducationDegree.TabIndex = 11;
            // 
            // AddTeacherControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbEducationDegree);
            Controls.Add(textBox1);
            Controls.Add(lblEducationDegree);
            Controls.Add(dateTDateOfBirth);
            Controls.Add(txtSalary);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblSalary);
            Controls.Add(DateDateOfBirth);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "AddTeacherControl";
            Size = new Size(709, 508);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label DateDateOfBirth;
        private Label lblSalary;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtSalary;
        private DateTimePicker dateTDateOfBirth;
        private TextBox textBox1;
        private Label lblEducationDegree;
        private ComboBox cmbEducationDegree;
    }
}
