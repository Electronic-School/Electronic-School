using System;
using System.Windows.Forms;
using SchoolManagementSystem.Controls;

namespace SchoolManagementSystem.Forms
{
    public partial class StudentForm : Form
    {
        private ListStudentsControl listStudentsControl;
        private AddStudentControl addStudentControl;
        private EditStudentControl updateStudentControl;
        private DeleteStudentControl deleteStudentControl;

        public StudentForm()
        {
            InitializeComponent();
            InitializeControls();
            ShowListStudents();
        }

        private void InitializeControls()
        {
            listStudentsControl = new ListStudentsControl();
            addStudentControl = new AddStudentControl();
            updateStudentControl = new EditStudentControl();
            deleteStudentControl = new DeleteStudentControl();

            // Ã⁄· Ã„Ì⁄ «·ﬂÊ‰ —Ê·«  »ÕÃ„ «·»«‰· «·—∆Ì”Ì
            listStudentsControl.Dock = DockStyle.Fill;
            addStudentControl.Dock = DockStyle.Fill;
            updateStudentControl.Dock = DockStyle.Fill;
            deleteStudentControl.Dock = DockStyle.Fill;

            // √Õœ«À ·· ÕœÌÀ «· ·ﬁ«∆Ì
            addStudentControl.OnStudentAdded += (s, e) => ShowListStudents();
            updateStudentControl.OnStudentUpdated += (s, e) => ShowListStudents();
            deleteStudentControl.OnStudentDeleted += (s, e) => ShowListStudents();
        }

        private void ClearMainPanel()
        {
            mainPanel.Controls.Clear();
        }

        private void ShowListStudents()
        {
            ClearMainPanel();
            listStudentsControl.LoadStudents(); //  ÕœÌÀ «·»Ì«‰« 
            mainPanel.Controls.Add(listStudentsControl);
            lblTitle.Text = "ﬁ«∆„… «·ÿ·«»";
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            ShowListStudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            mainPanel.Controls.Add(addStudentControl);
            lblTitle.Text = "≈÷«›… ÿ«·» ÃœÌœ";
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            mainPanel.Controls.Add(updateStudentControl);
            lblTitle.Text = " ⁄œÌ· »Ì«‰«  ÿ«·»";
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            mainPanel.Controls.Add(deleteStudentControl);
            lblTitle.Text = "Õ–› ÿ«·»";
        }
    }
}