namespace SchoolManagementSystem.Forms
{
    partial class ParentForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnSubmit = new Button();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            dtpBirth = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnNext2 = new Button();
            txtNotes = new TextBox();
            txtRelationShip = new TextBox();
            txtEmergency = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            btnChildNext = new Button();
            txtGrade = new TextBox();
            txtChildNotes = new TextBox();
            cmbGender = new ComboBox();
            dtpChildBirth = new DateTimePicker();
            txtChildAge = new TextBox();
            txtChildName = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            tabPage4 = new TabPage();
            dgvParents = new DataGridView();
            btnLoad = new Button();
            btnRefresh = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParents).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 414);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(744, 386);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parent Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(dtpBirth);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 380);
            panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(34, 237);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(98, 186);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(130, 23);
            txtAddress.TabIndex = 8;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(98, 149);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 7;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(98, 107);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 23);
            dtpBirth.TabIndex = 1;
            dtpBirth.ValueChanged += dtpBirth_ValueChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(98, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 6;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(98, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 5;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 189);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 152);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Age :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 113);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 71);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnNext2);
            tabPage2.Controls.Add(txtNotes);
            tabPage2.Controls.Add(txtRelationShip);
            tabPage2.Controls.Add(txtEmergency);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(txtPhone);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(744, 386);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNext2
            // 
            btnNext2.Location = new Point(37, 294);
            btnNext2.Name = "btnNext2";
            btnNext2.Size = new Size(75, 23);
            btnNext2.TabIndex = 10;
            btnNext2.Text = "Next";
            btnNext2.UseVisualStyleBackColor = true;
            btnNext2.Click += btnNext2_Click;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.InactiveCaption;
            txtNotes.Location = new Point(139, 200);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(200, 80);
            txtNotes.TabIndex = 9;
            txtNotes.TextChanged += txtNotes_TextChanged;
            // 
            // txtRelationShip
            // 
            txtRelationShip.Location = new Point(139, 153);
            txtRelationShip.Name = "txtRelationShip";
            txtRelationShip.Size = new Size(100, 23);
            txtRelationShip.TabIndex = 8;
            txtRelationShip.TextChanged += txtRelationShip_TextChanged;
            // 
            // txtEmergency
            // 
            txtEmergency.Location = new Point(139, 116);
            txtEmergency.Name = "txtEmergency";
            txtEmergency.Size = new Size(100, 23);
            txtEmergency.TabIndex = 7;
            txtEmergency.TextChanged += txtEmergency_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 29);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 5;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 203);
            label10.Name = "label10";
            label10.Size = new Size(123, 15);
            label10.TabIndex = 4;
            label10.Text = "Any note or  Address :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 156);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 3;
            label9.Text = "RelationShip :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 119);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 2;
            label8.Text = "Emergency Contact :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 77);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 1;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 32);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 0;
            label6.Text = "Phone Number :";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(744, 386);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Children Info ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnChildNext);
            panel2.Controls.Add(txtGrade);
            panel2.Controls.Add(txtChildNotes);
            panel2.Controls.Add(cmbGender);
            panel2.Controls.Add(dtpChildBirth);
            panel2.Controls.Add(txtChildAge);
            panel2.Controls.Add(txtChildName);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 380);
            panel2.TabIndex = 0;
            // 
            // btnChildNext
            // 
            btnChildNext.Location = new Point(24, 336);
            btnChildNext.Name = "btnChildNext";
            btnChildNext.Size = new Size(75, 23);
            btnChildNext.TabIndex = 12;
            btnChildNext.Text = "Next";
            btnChildNext.UseVisualStyleBackColor = true;
            btnChildNext.Click += btnChildNext_Click;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(102, 180);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 11;
            txtGrade.TextChanged += txtGrade_TextChanged;
            // 
            // txtChildNotes
            // 
            txtChildNotes.BackColor = SystemColors.ActiveBorder;
            txtChildNotes.Location = new Point(102, 224);
            txtChildNotes.Multiline = true;
            txtChildNotes.Name = "txtChildNotes";
            txtChildNotes.Size = new Size(200, 80);
            txtChildNotes.TabIndex = 10;
            txtChildNotes.TextChanged += txtChildNotes_TextChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(102, 136);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 9;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // dtpChildBirth
            // 
            dtpChildBirth.Location = new Point(102, 96);
            dtpChildBirth.Name = "dtpChildBirth";
            dtpChildBirth.Size = new Size(200, 23);
            dtpChildBirth.TabIndex = 8;
            dtpChildBirth.ValueChanged += dtpChildBirth_ValueChanged;
            // 
            // txtChildAge
            // 
            txtChildAge.Location = new Point(102, 59);
            txtChildAge.Name = "txtChildAge";
            txtChildAge.ReadOnly = true;
            txtChildAge.Size = new Size(100, 23);
            txtChildAge.TabIndex = 7;
            txtChildAge.TextChanged += txtChildAge_TextChanged;
            // 
            // txtChildName
            // 
            txtChildName.Location = new Point(102, 19);
            txtChildName.Name = "txtChildName";
            txtChildName.Size = new Size(100, 23);
            txtChildName.TabIndex = 6;
            txtChildName.TextChanged += txtChildName_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 237);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 5;
            label16.Text = "Notes :";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 183);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 4;
            label15.Text = "Grade : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 139);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 3;
            label14.Text = "Gender : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 102);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 2;
            label13.Text = "Date of Birth :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 62);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 1;
            label12.Text = "Age :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 22);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 0;
            label11.Text = "Child Name :";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnRefresh);
            tabPage4.Controls.Add(btnLoad);
            tabPage4.Controls.Add(dgvParents);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(744, 386);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Parents Table";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvParents
            // 
            dgvParents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParents.Location = new Point(0, 0);
            dgvParents.Name = "dgvParents";
            dgvParents.Size = new Size(741, 350);
            dgvParents.TabIndex = 0;
            dgvParents.CellContentClick += dgvParents_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(17, 356);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(120, 356);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ParentForm";
            Text = "ParentForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtAge;
        private DateTimePicker dtpBirth;
        private Button btnSubmit;
        private TextBox txtRelationShip;
        private TextBox txtEmergency;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtNotes;
        private Button btnNext2;
        private Panel panel2;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtChildAge;
        private TextBox txtChildName;
        private TextBox txtGrade;
        private TextBox txtChildNotes;
        private ComboBox cmbGender;
        private DateTimePicker dtpChildBirth;
        private Button btnChildNext;
        private Button btnRefresh;
        private Button btnLoad;
        private DataGridView dgvParents;
    }
}