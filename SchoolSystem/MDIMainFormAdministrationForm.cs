using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSystem.Controls;

namespace SchoolSystem
{
    public partial class MDIMainFormAdministrationForm : Form
    {
        //private int childFormNumber = 0;
        private Button currentButton;


        public MDIMainFormAdministrationForm()
        {
            InitializeComponent();
            LoadUserControl(new DashboardUC());
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5f, System.Drawing.FontStyle.Regular);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 43);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5f, System.Drawing.FontStyle.Regular);
                }
            }
        }

        private void LoadUserControl(UserControl us)
        {
            panelContent.Controls.Clear();

            us.Dock = DockStyle.Fill;

            panelContent.Controls.Add(us);

        }



        private void btnSidebarDashboard_Click(object sender, EventArgs e)
        {
            
            LoadUserControl(new DashboardUC());
        }

        private void btnSidebarStudentManage_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StudentFormUC());
        }

        private void btnSidebarTeacherManage_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TeacherFormUC());
        }
    }
}