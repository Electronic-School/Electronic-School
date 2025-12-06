namespace SchoolSystem.Controls
{
    partial class DashboardUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel pnlStudentCard;
        private Label lblStudentTitle;
        private Label lblStudentCount;
        private Panel pnlTeacherCard;
        private Label lblTeacherTitle;
        private Label lblTeacherCount;
        private Panel pnlClassesCard;
        private Label lblClassesTitle;
        private Label lblClassesCount;
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
            pnlStudentCard = new Panel();
            lblStudentCount = new Label();
            lblStudentTitle = new Label();
            pnlTeacherCard = new Panel();
            lblTeacherCount = new Label();
            lblTeacherTitle = new Label();
            pnlClassesCard = new Panel();
            lblClassesCount = new Label();
            lblClassesTitle = new Label();
            pnlStudentCard.SuspendLayout();
            pnlTeacherCard.SuspendLayout();
            pnlClassesCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStudentCard
            // 
            pnlStudentCard.BackColor = Color.CornflowerBlue;
            pnlStudentCard.Controls.Add(lblStudentCount);
            pnlStudentCard.Controls.Add(lblStudentTitle);
            pnlStudentCard.Location = new Point(50, 50);
            pnlStudentCard.Name = "pnlStudentCard";
            pnlStudentCard.Size = new Size(300, 150);
            pnlStudentCard.TabIndex = 0;
            // 
            // lblStudentCount
            // 
            lblStudentCount.Dock = DockStyle.Fill;
            lblStudentCount.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblStudentCount.ForeColor = Color.White;
            lblStudentCount.Location = new Point(0, 50);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(300, 100);
            lblStudentCount.TabIndex = 1;
            lblStudentCount.Text = "0000";
            lblStudentCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentTitle
            // 
            lblStudentTitle.Dock = DockStyle.Top;
            lblStudentTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentTitle.ForeColor = Color.White;
            lblStudentTitle.Location = new Point(0, 0);
            lblStudentTitle.Name = "lblStudentTitle";
            lblStudentTitle.Size = new Size(300, 50);
            lblStudentTitle.TabIndex = 0;
            lblStudentTitle.Text = "📊 Total Students";
            lblStudentTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTeacherCard
            // 
            pnlTeacherCard.BackColor = Color.MediumSeaGreen;
            pnlTeacherCard.Controls.Add(lblTeacherCount);
            pnlTeacherCard.Controls.Add(lblTeacherTitle);
            pnlTeacherCard.Location = new Point(400, 50);
            pnlTeacherCard.Name = "pnlTeacherCard";
            pnlTeacherCard.Size = new Size(300, 150);
            pnlTeacherCard.TabIndex = 1;
            // 
            // lblTeacherCount
            // 
            lblTeacherCount.Dock = DockStyle.Fill;
            lblTeacherCount.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTeacherCount.ForeColor = Color.White;
            lblTeacherCount.Location = new Point(0, 50);
            lblTeacherCount.Name = "lblTeacherCount";
            lblTeacherCount.Size = new Size(300, 100);
            lblTeacherCount.TabIndex = 1;
            lblTeacherCount.Text = "000";
            lblTeacherCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeacherTitle
            // 
            lblTeacherTitle.Dock = DockStyle.Top;
            lblTeacherTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTeacherTitle.ForeColor = Color.White;
            lblTeacherTitle.Location = new Point(0, 0);
            lblTeacherTitle.Name = "lblTeacherTitle";
            lblTeacherTitle.Size = new Size(300, 50);
            lblTeacherTitle.TabIndex = 0;
            lblTeacherTitle.Text = "🧑‍🏫 Total Teachers";
            lblTeacherTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlClassesCard
            // 
            pnlClassesCard.BackColor = Color.OrangeRed;
            pnlClassesCard.Controls.Add(lblClassesCount);
            pnlClassesCard.Controls.Add(lblClassesTitle);
            pnlClassesCard.Location = new Point(750, 50);
            pnlClassesCard.Name = "pnlClassesCard";
            pnlClassesCard.Size = new Size(300, 150);
            pnlClassesCard.TabIndex = 2;
            // 
            // lblClassesCount
            // 
            lblClassesCount.Dock = DockStyle.Fill;
            lblClassesCount.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblClassesCount.ForeColor = Color.White;
            lblClassesCount.Location = new Point(0, 50);
            lblClassesCount.Name = "lblClassesCount";
            lblClassesCount.Size = new Size(300, 100);
            lblClassesCount.TabIndex = 1;
            lblClassesCount.Text = "00";
            lblClassesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClassesTitle
            // 
            lblClassesTitle.Dock = DockStyle.Top;
            lblClassesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblClassesTitle.ForeColor = Color.White;
            lblClassesTitle.Location = new Point(0, 0);
            lblClassesTitle.Name = "lblClassesTitle";
            lblClassesTitle.Size = new Size(300, 50);
            lblClassesTitle.TabIndex = 0;
            lblClassesTitle.Text = "📚 Total Classes";
            lblClassesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlClassesCard);
            Controls.Add(pnlTeacherCard);
            Controls.Add(pnlStudentCard);
            Name = "DashboardUC";
            Size = new Size(1166, 724);
            pnlStudentCard.ResumeLayout(false);
            pnlTeacherCard.ResumeLayout(false);
            pnlClassesCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
