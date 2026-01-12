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

namespace SchoolSystem
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();

            ShowUserControl(new TeacherGridUC());
        }

        private void ShowUserControl(UserControl usercontrol)
        {
            pnlMainContent.Controls.Clear();
            usercontrol.Dock=DockStyle.Fill;
            pnlMainContent.Controls.Add(usercontrol);
        }



        private void btnShowAllTeachers_Click(object sender, EventArgs e)
        {
            ShowUserControl(new TeacherGridUC());
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            ShowUserControl(new AddTeacherControl());
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            ShowUserControl(new SearchTeacherControl());
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            //ShowUserControl(new UpdateTeacherControl());
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            //ShowUserControl(new DeleteTeacherControl());
        }

    }
}
