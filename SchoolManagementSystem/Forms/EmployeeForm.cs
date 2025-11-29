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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            dtpBirth.ValueChanged += dtpBirth_ValueChanged;
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

            cmbStatus.SelectedIndex = 0;   // يختار Active تلقائيًا

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFName.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Only letters are allowed.");
                txtFName.Text = "";
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLName.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Only letters are allowed.");
                txtLName.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email.");
                txtEmail.Text = "";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtPhone.Text, out _) && txtPhone.Text != "")
            {
                MessageBox.Show("Phone number must contain digits only.");
                txtPhone.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtAddress.Text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Address can contain only letters, numbers and spaces.");
                    txtAddress.Text = "";
                    return;
                }
            }
        }

        private void btnNaet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("Please enter first name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Please enter last name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.");
                return;
            }

            tabControl1.SelectedIndex = 1;
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime birth = dtpBirth.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - birth.Year;

            if (birth > today.AddYears(-age))
                age--;

            txtAge.Text = age.ToString();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSalary.Text, out _) && txtSalary.Text != "")
            {
                MessageBox.Show("Please enter numbers only.");
                txtSalary.Text = "";
            }
        }

        private void txtJobTitle_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtJobTitle.Text)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Job title cannot contain numbers.");
                    txtJobTitle.Text = "";
                    break;
                }
            }
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtDepartment.Text)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Department cannot contain numbers.");
                    txtDepartment.Text = "";
                    break;
                }
            }
        }

        private void dtpHireDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHireDate.Value > DateTime.Now)
            {
                MessageBox.Show("Hire Date cannot be in the future.");
                dtpHireDate.Value = DateTime.Now;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cmbStatus.SelectedItem.ToString();
            // هنا تقدر تستخدم قيمة status لو تحتاجها

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Please enter the department.");
                return;
            }

            // التحقق من Job Title
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Please enter the job title.");
                return;
            }

            // التحقق من Salary (لابد أرقام فقط)
            if (!decimal.TryParse(txtSalary.Text, out _))
            {
                MessageBox.Show("Salary must be numbers only.");
                txtSalary.Text = "";
                return;
            }

            // التحقق من حالة الموظف
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select employee status.");
                return;
            }

            // التحقق من تاريخ التوظيف (اختياري لأن المستخدم ما يقدر يتركه فاضي)
            DateTime hire = dtpHireDate.Value;
            if (hire > DateTime.Today)
            {
                MessageBox.Show("Hire date cannot be in the future.");
                return;
            }

            // إذا كله تمام → يروح للتاب التالي
            tabControl1.SelectedIndex = 2;  // System Info

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a name or ID to search.");
                return;
            }

            // TODO: Query database here later
            MessageBox.Show($"Searching for: {keyword}");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update.");
                return;
            }

            // مثال: الحصول على ID من الجدول
            string empId = dgvEmployees.SelectedRows[0].Cells[0].Value.ToString();

            MessageBox.Show($"Opening record for update. Employee ID: {empId}");

            // TODO: Fill fields with data later

            tabControl1.SelectedTab = tabPage1; // personal info

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            string empId = dgvEmployees.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete Employee ID: {empId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                // TODO: delete later from database
                MessageBox.Show("Employee deleted (not really yet).");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";              // يمسح خانة البحث
            dgvEmployees.ClearSelection();    // يلغي أي صف محدد في الجدول

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
