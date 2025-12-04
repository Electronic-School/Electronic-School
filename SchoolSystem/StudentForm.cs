using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSystem.Controls;
using System;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            ShowControl(new ShowAllStudentsControl());

        }

        private void ShowControl(UserControl control)
        {
            pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(control);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowControl(new ShowAllStudentsControl());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowControl(new AddStudentControl());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowControl(new SearchStudentControl());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowControl(new UpdateStudentControl());
        }

        private void InitializeComponent()
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShowControl(new DeleteStudentControl());
        }
    }
}
