using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data;
using SchoolSystem.Models;
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

        private readonly Color PrimaryColor = Color.FromArgb(41, 128, 185);
        private readonly Color SuccessColor = Color.FromArgb(39, 174, 96);
        private readonly Color ErrorColor = Color.FromArgb(231, 76, 60);
        private readonly Color DefaultColor = Color.FromArgb(149, 165, 166);

        // متغيرات للبيانات المحددة
        private int selectedLocationId = 0;

        public event Action<int> TeacherAdded;

        public AddTeacherControl()
        {
            InitializeComponent();
            if (toolTip == null)
            {
                toolTip = new ToolTip();
            }
            ApplyModernDesign();
            InitializeDatePicker();

            //this.Load += AddTeacherControl_Load();
        }

        //private void AddTeacherControl_Load(object sender, EventArgs e)
        //{

        //}
        private void InitializeEducationCombo()
        {
            if (cmbEducationDegree != null)
            {
                cmbEducationDegree.Items.Clear();
                cmbEducationDegree.Items.AddRange(new object[] {
            "Bachelor's Degree",  // بكالوريوس
            "Master's Degree",    // ماجستير
            "PhD",                // دكتوراة
            "Diploma",            // دبلوم
            "High School"         // ثانوية عامة
        });
                cmbEducationDegree.SelectedIndex = 0; // اختيار افتراضي
            }
        }
        private void ApplyModernDesign()
        {
            this.BackColor = Color.White;

            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10);

            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10);

            //txtEducationDegree.BackColor = Color.White;
            //txtEducationDegree.BorderStyle = BorderStyle.FixedSingle;
            //txtEducationDegree.Font = new Font("Segoe UI", 10);

            txtTeachingSubject.BackColor = Color.White;
            txtTeachingSubject.BorderStyle = BorderStyle.FixedSingle;
            txtTeachingSubject.Font = new Font("Segoe UI", 10);

            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 10);

            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10);

            txtSocialStatus.BackColor = Color.White;
            txtSocialStatus.BorderStyle = BorderStyle.FixedSingle;
            txtSocialStatus.Font = new Font("Segoe UI", 10);

            txtSalary.BackColor = Color.White;
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 10);


            dtpDateOfBirth.Font = new Font("Segoe UI", 10);
            dtpDateOfBirth.CalendarFont = new Font("Segoe UI", 9);

            dtpStartWorkingDate.Font = new Font("Segoe UI", 10);
            dtpStartWorkingDate.CalendarFont = new Font("Segoe UI", 9);

            if (cmbEducationDegree != null)
            {
                cmbEducationDegree.BackColor = Color.White;
                cmbEducationDegree.Font = new Font("Segoe UI", 10);
            }
            StyleButton(btnAddLocation, PrimaryColor);
            StyleButton(btnClear, DefaultColor); // رمادي
            StyleButton(btnAddTeacher, SuccessColor, true);

            //if(toolTip != null)
            //{
            //    if()
            //}

            // tooltips
            toolTip.SetToolTip(txtFirstName, "Enter teacher's first name");
            toolTip.SetToolTip(txtLastName, "Enter teacher's last name");
            toolTip.SetToolTip(dtpDateOfBirth, "Select teacher's date of birth");
            toolTip.SetToolTip(btnAddLocation, "Add location details");
            toolTip.SetToolTip(cmbEducationDegree, "Enter teacher's education degree");
            toolTip.SetToolTip(txtTeachingSubject, "Enter the subject the teacher teaches");
            toolTip.SetToolTip(txtPhoneNumber, "Enter teacher's phone number");
            toolTip.SetToolTip(txtEmail, "Enter teacher's email address");
            toolTip.SetToolTip(txtSocialStatus, "Enter teacher's social status (e.g., Married, Single)");
            toolTip.SetToolTip(txtSalary, "Enter teacher's monthly salary");
            toolTip.SetToolTip(dtpStartWorkingDate, "Select the teacher's start working date");
            toolTip.SetToolTip(btnAddTeacher, "Save new teacher");
            toolTip.SetToolTip(btnClear, "Clear all fields");
        }

        private void StyleButton(Button button, Color backColor, bool isPrimary = false)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", isPrimary ? 10 : 9, isPrimary ? FontStyle.Bold : FontStyle.Regular);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(10, 5, 10, 5);

            // تأثير hover
            button.MouseEnter += (s, e) => button.BackColor = ControlPaint.Light(backColor, 0.1f);
            button.MouseLeave += (s, e) => button.BackColor = backColor;
        }

        private void InitializeDatePicker()
        {
            dtpDateOfBirth.MinDate = new DateTime(1950, 1, 1);
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-20); // افتراض أن المعلم لا يقل عمره عن 20
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-30); // قيمة افتراضية: عمر 30 سنة
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;

            dtpStartWorkingDate.MaxDate = DateTime.Today;
            dtpStartWorkingDate.Value = DateTime.Today;
            dtpStartWorkingDate.Format = DateTimePickerFormat.Short;
        }


        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                btnAddTeacher.Enabled = false;

                decimal? salary = null;
                if (decimal.TryParse(txtSalary.Text.Trim(), out decimal tempSalary))
                    salary = tempSalary;

                using (var context = new SchoolDbContext())
                {
                    var location = context.Locations.Find(selectedLocationId);

                    if (location == null)
                    {
                        MessageBox.Show("Please select a valid location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newTeacher = new Teacher
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        DateOfBirth = dtpDateOfBirth.Value.Date,
                        Location = location,

                        EducationDegree = cmbEducationDegree.SelectedItem.ToString(),
                        TeachingSubject = txtTeachingSubject.Text.Trim(),
                        PhoneNumber = txtPhoneNumber.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        SocialStatus = txtSocialStatus.Text.Trim(),
                        Salary = salary,
                        StartWorkingDate = dtpStartWorkingDate.Value.Date
                    };

                    context.Teachers.Add(newTeacher);
                    context.SaveChanges();

                    ShowSuccessMessage(newTeacher.TeacherId);
                    TeacherAdded?.Invoke(newTeacher.TeacherId);

                    LogTeacherCreation(newTeacher.TeacherId, newTeacher.FirstName, newTeacher.LastName);
                    ResetForm();
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add teacher:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnAddTeacher.Enabled = true;
            }
        }

        private bool ValidateInputs()
        {

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(cmbEducationDegree.Text) || string.IsNullOrWhiteSpace(txtTeachingSubject.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                ShowStatusMessage("Please fill all required text fields.", ErrorColor);
                return false;
            }
            // check location
            if (selectedLocationId == 0)
            {
                ShowStatusMessage("Please add location details for the teacher.", ErrorColor);
                btnAddLocation.Focus();
                return false;
            }

            // salary validate
            if (!string.IsNullOrWhiteSpace(txtSalary.Text) && !decimal.TryParse(txtSalary.Text.Trim(), out _))
            {
                ShowStatusMessage("Salary must be a valid number.", ErrorColor);
                txtSalary.Focus();
                return false;
            }

            ShowStatusMessage(string.Empty, DefaultColor);
            return true;
        }

        private void ShowSuccessMessage(int teacherId)
        {
            string message = $"Teacher added successfully!\n\n" +
                           $"Teacher ID: {teacherId}\n" +
                           $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                           $"Subject: {txtTeachingSubject.Text}";

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowStatusMessage(string message, Color color)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
            lblStatus.Visible = !string.IsNullOrEmpty(message);
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            //txtEducationDegree.Clear();
            if (cmbEducationDegree != null) cmbEducationDegree.SelectedIndex = 0; 
            txtTeachingSubject.Clear();
            txtSalary.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtSocialStatus.Clear();

            dtpDateOfBirth.Value = DateTime.Today.AddYears(-30);
            dtpStartWorkingDate.Value = DateTime.Today;

            selectedLocationId = 0;
            txtFirstName.Focus();
            ShowStatusMessage("Form cleared", DefaultColor);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all fields?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetForm();
            }
        }




        // ##################################################################################################################################
        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            var locationForm = new Form
            {
                Text = "Add Location Details",
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Size = new Size(520, 580)
            };


            var addLocationControl = new AddLocationControl(selectedLocationId);

            addLocationControl.Dock = DockStyle.Fill;

            addLocationControl.LocationCreated += (locationId) =>
            {
                this.selectedLocationId = locationId;
                locationForm.DialogResult = DialogResult.OK;
                locationForm.Close();
            };

            locationForm.Controls.Add(addLocationControl);

            locationForm.ShowDialog();

            UpdateLocationButtonStatus();
        }

        private void UpdateLocationButtonStatus()
        {
            if (selectedLocationId > 0)
            {
                btnAddLocation.Text = $" Location Added (ID: {selectedLocationId})";
                StyleButton(btnAddLocation, SuccessColor);
            }
            else
            {
                btnAddLocation.Text = "📍 Add Location Details";
                StyleButton(btnAddLocation, PrimaryColor);
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        private void DtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            int age = CalculateAge(dtpDateOfBirth.Value);
            lblAgeHint.Text = $"Age: {age} years";
            lblAgeHint.Visible = true;
        }

        private void LogTeacherCreation(int teacherId, string firstName, string lastName)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] New teacher created - " +
                               $"ID: {teacherId}, Name: {firstName} {lastName}, " +
                               $"Subject: {txtTeachingSubject.Text}, Location: {selectedLocationId}";

            System.Diagnostics.Debug.WriteLine(logMessage);
        }

        private void TxtTeachingSubject_TextChanged(object sender, EventArgs e)
        {

        }

    }
}