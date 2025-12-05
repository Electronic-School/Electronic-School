namespace SchoolSystem
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlSidebar;
        private Panel pnlMain;
        private Button btnShowAll;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;

         private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            pnlMain = new Panel();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSteelBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1482, 71);
            pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 0;
            label1.Text = "Electronic School";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(573, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Student Management";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.LightGray;
            pnlSidebar.Controls.Add(btnDelete);
            pnlSidebar.Controls.Add(btnEdit);
            pnlSidebar.Controls.Add(btnAdd);
            pnlSidebar.Controls.Add(btnSearch);
            pnlSidebar.Controls.Add(btnShowAll);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 71);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(262, 732);
            pnlSidebar.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Top;
            btnDelete.Location = new Point(0, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(262, 49);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete Student";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Top;
            btnEdit.Location = new Point(0, 145);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(262, 47);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Student";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.Location = new Point(0, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(262, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Student";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.Location = new Point(0, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(262, 49);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Student By ID";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Dock = DockStyle.Top;
            btnShowAll.Location = new Point(0, 0);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(262, 50);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All Students";
            btnShowAll.Click += btnShowAll_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(262, 71);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1220, 732);
            pnlMain.TabIndex = 0;
            // 
            // StudentForm
            // 
            ClientSize = new Size(1482, 803);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "StudentForm";
            Text = "Student Management System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
