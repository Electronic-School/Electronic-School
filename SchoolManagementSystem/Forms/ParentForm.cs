using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            this.dtpBirth.ValueChanged += dtpBirth_ValueChanged;

        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Year - dtpBirth.Value.Year;

            if (dtpBirth.Value > today.AddYears(-age))
                age--;

            txtAge.Text = age.ToString();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, @"[^a-zA-Z\s]"))
            {
                MessageBox.Show("Only letters are allowed.");
                txtFirstName.Text = "";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, @"[^a-zA-Z\s]"))
            {
                MessageBox.Show("Only letters are allowed.");
                txtLastName.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtAddress.Text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Address can contain letters, numbers and spaces only.");
                    txtAddress.Text = "";
                    return;
                }
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("Age must be numbers only.");
                txtAge.Text = "";
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name.");
                return;
            }

            // التحقق من الاسم الأخير
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name.");
                return;
            }

            // التحقق من العمر
            if (string.IsNullOrWhiteSpace(txtAge.Text) || txtAge.Text == "0")
            {
                MessageBox.Show("Please enter valid Age.");
                return;
            }

            // التحقق من العنوان
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter Address.");
                return;
            }

            // لو كل شيء تمام → ننتقل للتاب الثاني
            tabControl1.SelectedIndex = 1;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtPhone.Text, out _) && txtPhone.Text != "")
            {
                MessageBox.Show("Phone number must contain digits only.");
                txtPhone.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }

        private void txtEmergency_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtEmergency.Text, out _) && txtEmergency.Text != "")
            {
                MessageBox.Show("Emergency contact must contain digits only.");
                txtEmergency.Text = "";
            }
        }

        private void txtRelationShip_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtRelationShip.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Relationship must contain letters only.");
                    txtRelationShip.Text = "";
                    break;
                }
            }
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            if (txtNotes.Text.Length > 250)
            {
                MessageBox.Show("Notes cannot exceed 250 characters.");
                txtNotes.Text = txtNotes.Text.Substring(0, 250);
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                return;
            }

            // الانتقال للتاب الثالث
            tabControl1.SelectedIndex = 2;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtChildName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtChildName.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("Name must contain letters only.");
                txtChildName.Text = "";
            }
        }

        private void txtChildAge_TextChanged(object sender, EventArgs e)
        {
            txtChildAge.ReadOnly = true;
        }

        private void dtpChildBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dtpChildBirth.Value.Year;

            if (dtpChildBirth.Value.Date > today.AddYears(-age))
                age--;

            txtChildAge.Text = age.ToString();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            string gender = cmbGender.SelectedItem.ToString();

            if (gender != "Male" && gender != "Female")
            {
                MessageBox.Show("Invalid gender selected.");
                cmbGender.SelectedIndex = -1;
            }
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtGrade.Text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Grade can contain letters, numbers, and spaces only.");
                    txtGrade.Text = "";
                    break;
                }
            }
        }

        private void txtChildNotes_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtChildNotes.Text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c) && c != '.' && c != ',')
                {
                    MessageBox.Show("Notes can contain text and numbers only.");
                    txtChildNotes.Text = "";
                    return;
                }
            }
        }
        private void ClearAllFields()
        {
            // Parent Info
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpBirth.Value = DateTime.Today;
            txtAge.Text = "";
            txtAddress.Text = "";

            // Contact Info
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtEmergency.Text = "";
            txtRelationShip.Text = "";
            txtNotes.Text = "";

            // Children Info
            txtChildName.Text = "";
            dtpChildBirth.Value = DateTime.Today;
            txtChildAge.Text = "";
            cmbGender.SelectedIndex = -1;
            txtGrade.Text = "";
            txtChildNotes.Text = "";
        }

        private void btnChildNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter parent's first name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter parent's last name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter parent's address.");
                return;
            }

            // التحقق من التاب الثاني (Contact Info)
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                return;
            }

            // التحقق من التاب الثالث (Children Info)
            if (string.IsNullOrWhiteSpace(txtChildName.Text))
            {
                MessageBox.Show("Please enter child's name.");
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select child's gender.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please enter grade.");
                return;
            }

            // إذا وصل هنا معناها كل شي تمام ✔️
            MessageBox.Show("Parent and child information saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ممكن هنا تعمل مسح للحقول بعد الحفظ:
            ClearAllFields();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void dgvParents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
