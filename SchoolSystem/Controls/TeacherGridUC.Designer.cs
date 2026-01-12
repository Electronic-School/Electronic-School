namespace SchoolSystem.Controls
{
    partial class TeacherGridUC
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private DataGridView dgvTeachers;

        /// <summary> 
        /// Required designer variable.
        /// </summary>

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


            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            pnlHeader = new Panel();
            lblTitle = new Label();
            dgvTeachers = new DataGridView(); 

            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();

            // 
            // pnlHeader
            // 
            // استخدام الألوان والأبعاد الخاصة بـ ShowAllStudentsControl
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 70);
            pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 37);
            // ✅ تغيير العنوان إلى المدرسين
            lblTitle.Text = "👨‍🏫 All Teachers List";

            // 
            // dgvTeachers (كان اسمه dgvStudents)
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(236, 240, 241);
            dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.BackgroundColor = Color.White;
            dgvTeachers.BorderStyle = BorderStyle.None;
            dgvTeachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTeachers.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dgvTeachers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.EnableHeadersVisualStyles = false;
            dgvTeachers.GridColor = Color.Black;
            dgvTeachers.Location = new Point(0, 70);
            dgvTeachers.Name = "dgvTeachers"; // ✅ تغيير الاسم البرمجي
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersVisible = false;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.RowTemplate.Height = 40;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(900, 610);
            dgvTeachers.TabIndex = 1;
            // 
            // TeacherGridUC 
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvTeachers);
            Controls.Add(pnlHeader);
            Name = "TeacherGridUC"; 
            Size = new Size(900, 680);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

    }
}
