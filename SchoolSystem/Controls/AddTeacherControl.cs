using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Controls
{
    public partial class AddTeacherControl : UserControl
    {
        public AddTeacherControl()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(new Label()
            {
                Text = "Add A new Teacehr: ",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
