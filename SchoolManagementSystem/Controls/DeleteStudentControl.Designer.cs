namespace SchoolManagementSystem.Controls
{
    partial class DeleteStudentControl
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.lblParentId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.pnlStudentInfo.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "حذف طالب";

            // lblStudentId
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(550, 60);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(60, 13);
            this.lblStudentId.TabIndex = 1;
            this.lblStudentId.Text = "رقم الطالب:";

            // txtStudentId
            this.txtStudentId.Location = new System.Drawing.Point(350, 57);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(150, 20);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentId_KeyPress);
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);

            // btnLoad
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(220, 55);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 25);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "تحميل البيانات";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // pnlStudentInfo
            this.pnlStudentInfo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentInfo.Controls.Add(this.lblInfoTitle);
            this.pnlStudentInfo.Controls.Add(this.lblParentId);
            this.pnlStudentInfo.Controls.Add(this.lblLocationId);
            this.pnlStudentInfo.Controls.Add(this.lblName);
            this.pnlStudentInfo.Location = new System.Drawing.Point(50, 100);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(700, 150);
            this.pnlStudentInfo.TabIndex = 3;
            this.pnlStudentInfo.DoubleClick += new System.EventHandler(this.ShowStudentDetails);

            // lblInfoTitle
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblInfoTitle.Location = new System.Drawing.Point(300, 10);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(100, 17);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "بيانات الطالب:";

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(500, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "الاسم: ---";

            // lblLocationId
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.lblLocationId.Location = new System.Drawing.Point(500, 80);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(80, 17);
            this.lblLocationId.TabIndex = 2;
            this.lblLocationId.Text = "رقم الموقع: ---";

            // lblParentId
            this.lblParentId.AutoSize = true;
            this.lblParentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.lblParentId.Location = new System.Drawing.Point(500, 110);
            this.lblParentId.Name = "lblParentId";
            this.lblParentId.Size = new System.Drawing.Size(68, 17);
            this.lblParentId.TabIndex = 3;
            this.lblParentId.Text = "رقم الأب: ---";

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(420, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف الطالب";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(280, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "مسح الكل";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // UC_DeleteStudent
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlStudentInfo);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_DeleteStudent";
            this.Size = new System.Drawing.Size(800, 500);
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.Label lblParentId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfoTitle;
    }
}