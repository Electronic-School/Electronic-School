using SchoolSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Controls
{
    public partial class TeacherManagementUC : UserControl
    {
        public TeacherManagementUC()
        {
            InitializeComponent();
            this.Load += TeacherManagementUC_Load;
            btnAdd.Click += btnAdd_Click;

        }

        private async void TeacherManagementUC_Load(object sender, EventArgs e)
        {
            //await LoadTeachersData();
            ShowTeacherGrid();
        }

        private void LoadContent(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        public void ShowTeacherGrid()
        {
            TeacherGridUC gridUC = new TeacherGridUC();

            //gridUC.AddNewTeacher += (s, e) => ShowTeacherDetails(null);
            gridUC.EditClicked += (s, teacherId) => ShowTeacherDetails((int)teacherId);
            LoadContent(gridUC);
        }

        public void ShowTeacherDetails(int? teacherId)
        {
            if (teacherId == null)
            {
                MessageBox.Show("Implement logic to open Add New Teacher form.", "Navigation");
            }
            else
            {
                MessageBox.Show($"Implement logic to open Edit Teacher form for ID: {teacherId}", "Navigation");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            AddTeacherControl addControl = new AddTeacherControl();
            LoadContent(addControl);
            

            //panelContent.Controls.Clear();

            //AddTeacherControl addTeacherControl = new AddTeacherControl();

            //addTeacherControl.Dock = DockStyle.Fill;

            //panelContent.Controls.Add(addTeacherControl);

            //addTeacherControl.BringToFront();
        }
    }
}
